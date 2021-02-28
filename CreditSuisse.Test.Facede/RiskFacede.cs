
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

        /// <summary>
        /// Get Risk Trade on Service
        /// </summary>
        /// <param name="trades">List Trandes</param>
        /// <returns>list of risks</returns>
        public IList<string> GetRiskTrade(IList<ITrade> trades)
        {
            IList<string> listRiskTrade = new List<string>();

            listRiskTrade = serviceRisk.GetRiskTrade(trades);

            return listRiskTrade;
        }

    }
}
