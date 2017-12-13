using FunkyFadz.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunkyFadz.Models;
using FunkyFadz.Data;

namespace FunkyFadz.Services
{
    
    public class FunkyFadzService : IFunkyFadzService
    {
        private readonly Guid _userId;
        public FunkyFadzService(Guid userId)
        {
            _userId = userId;
        }

        public FunkyFadzService()
        {

        }

        public bool CreateFunkyFadz(FunkyFadzCreateModel model)
        {
            var entity =
                new FunkyFadzEntity
                {
                    OwnerId = _userId,
                    FadType = model.FadType,
                    Description = model.Description,
                    Year = model.Year,
                    CreatedUtc = DateTimeOffset.UtcNow
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.FunkyFadz.Add(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteFunkyFadz(int FunkyFadzId)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .FunkyFadz
                        .Single(e => e.FunkyFadzId == FunkyFadzId && e.OwnerId == _userId);

                //Mark for deletion
                ctx.FunkyFadz.Remove(entity);

                //Only do one change
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<FunkyFadzListModel> GetFunkyFadz()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = 
                    ctx
                            .FunkyFadz
                            .Select(
                                e =>
                                    new FunkyFadzListModel
                                    {
                                        FunkyFadzId = e.FunkyFadzId,
                                        FadType = e.FadType,
                                        Year = e.Year,
                                        CreatedUtc = e.CreatedUtc
                                    }
                            );

                return query.ToArray();
            }
        }

        public IEnumerable<FunkyFadzListModel> GetFunkyFadz(Guid UserId)
        {
            using (var ctx = new ApplicationDbContext())
            {   
                var query =
                    ctx
                            .FunkyFadz
                            .Where(e => e.OwnerId == UserId)
                            .Select(
                                e =>
                                    new FunkyFadzListModel
                                    {
                                        FunkyFadzId = e.FunkyFadzId,
                                        FadType = e.FadType,
                                        Year = e.Year,
                                        CreatedUtc = e.CreatedUtc
                                    }
                            );

                return query.ToArray();
            }
        }

        public FunkyFadzDetailsModel GetFunkyFadzById(int FunkyFadzId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .FunkyFadz
                        .Single(e => e.FunkyFadzId == FunkyFadzId);

                return
                    new FunkyFadzDetailsModel
                    {
                        FunkyFadzId = entity.FunkyFadzId,
                        FadType = entity.FadType,
                        Description = entity.Description,
                        Year = entity.Year,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }

        public bool UpdateFunkyFadz(FunkyFadzEditModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .FunkyFadz
                        .Single(e => e.FunkyFadzId == model.FunkyFadzId && e.OwnerId == _userId);

                entity.FadType = model.FadType;
                entity.Description = model.Description;
                entity.Year = model.Year;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }
    }




}
