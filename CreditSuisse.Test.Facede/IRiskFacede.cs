using CreditSuisse.Test.Entitiy.Interface;
using System.Collections.Generic;

namespace CreditSuisse.Test.Facede
{
    public interface IRiskFacede
    {
        IList<string> GetRiskTrade(IList<ITrade> trades);
    }
}