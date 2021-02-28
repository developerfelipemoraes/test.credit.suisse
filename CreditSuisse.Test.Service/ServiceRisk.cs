using CreditSuisse.Test.Entitiy.Interface;
using CreditSuisse.Test.Service.Interface;
using System;
using System.Collections.Generic;

namespace CreditSuisse.Test.Service
{
    public class ServiceRisk : IServiceRisk
    {
        private ITradeRiskService TradeRiskService { get; set; }

        public IList<string> GetRiskTrade(IList<ITrade> trades)
        {
            IList<string> listRiskTrade = new List<string>();

            var businessTrade = new Dictionary<string, Delegate>
            {
                ["Private"] = new Func<double, string>(GetPublicRisk),
                ["Public"] = new Func<double, string>(GetPrivateRisk)
            };

            foreach (var trade in trades)
            {
                var resultRisk = businessTrade[trade.ClientSector].DynamicInvoke(trade.Value);
                listRiskTrade.Add(resultRisk.ToString());
            }

            return listRiskTrade;
        }

        private string GetPublicRisk(double operationValue)
        {
            TradeRiskService = new PrivateRiskService();
            return TradeRiskService.GetRisk(operationValue, 0);
        }

        private string GetPrivateRisk(double operationValue)
        {
            TradeRiskService = new PublicRiskService();
            return TradeRiskService.GetRisk(operationValue, 0);
        }
    }
}
