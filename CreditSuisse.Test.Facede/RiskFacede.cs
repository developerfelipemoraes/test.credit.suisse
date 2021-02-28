
using CreditSuisse.Test.Entitiy.Interface;
using CreditSuisse.Test.Service;
using CreditSuisse.Test.Service.Interface;
using System.Collections.Generic;

namespace CreditSuisse.Test.Facede
{
    public class RiskFacede : IRiskFacede
    {
        private readonly IServiceRisk serviceRisk;

        public RiskFacede()
        {
            serviceRisk = new ServiceRisk();
        }

        public IList<string> GetRiskTrade(IList<ITrade> trades)
        {
            IList<string> listRiskTrade = new List<string>();

            listRiskTrade = serviceRisk.GetRiskTrade(trades);

            return listRiskTrade;
        }

    }
}
