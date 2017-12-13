using FunkyFadz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyFadz.Contracts
{
   public interface IFunkyFadzService
    {
        bool CreateFunkyFadz(FunkyFadzCreateModel model);
        IEnumerable<FunkyFadzListModel> GetFunkyFadz();
        FunkyFadzDetailsModel GetFunkyFadzById(int FunkyFadzId);
        bool UpdateFunkyFadz(FunkyFadzEditModel model);
        bool DeleteFunkyFadz(int FunkyFadzId);
    }
}
