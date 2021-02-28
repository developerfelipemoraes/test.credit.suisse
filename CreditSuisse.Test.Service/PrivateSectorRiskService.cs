
using CreditSuisse.Test.Service.Interface;
using System.Configuration;

namespace CreditSuisse.Test.Service
{
    public class PrivateSectorRiskService : ITradeRiskService
    {
        /// <summary>
        /// Get Private Risk
        /// </summary>
        /// <param name="value">value trade operation</param>
        /// <param name="parameterRisk">parameter to get risk type</param>
        /// <returns>Type Risk</returns>
        public string GetRisk(double value, double parameterRisk)
        {
            if (value > parameterRisk)
            {
                return ConfigurationManager.AppSettings["HIGHRISK"];
            }
            else
            {
                return "NOT-DEFINED-BY-RISK";
            }
        }
    }
}
