using FunkyFadz.Contracts;
using FunkyFadz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyFadzWeb.Tests.Controller.FunkyFadzControllerTest
{
    public class FakeFunkyFadzService : IFunkyFadzService
    {
        public int CreateFunkyFadzCallCount { get; private set; }
        public bool CreateFunkyFadzReturnValue { private get; set; } = true;

        public bool CreateFunkyFadz(FunkyFadzCreateModel model)
        {
            CreateFunkyFadzCallCount++;

            return CreateFunkyFadzReturnValue;
        }

        public bool DeleteFunkyFadz(int FunkyFadzId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FunkyFadzListModel> GetFunkyFadz()
        {
            throw new NotImplementedException();
        }

        public FunkyFadzDetailsModel GetFunkyFadzById(int FunkyFadzId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateFunkyFadz(FunkyFadzEditModel model)
        {
            throw new NotImplementedException();
        }
    }
}
