using CreditSuisse.Test.Entitiy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Test.Service.Interface
{
    public interface IServiceRisk
    {
        IList<string> GetRiskTrade(IList<ITrade> trades);
    }
}
