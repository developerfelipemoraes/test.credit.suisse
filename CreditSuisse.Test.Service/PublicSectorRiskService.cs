
using CreditSuisse.Test.Service.Interface;
using System.Configuration;

namespace CreditSuisse.Test.Service
{
    /// <summary>
    /// Class of Public Sector Risk
    /// </summary>
    public class PublicSectorRiskService : ITradeRiskService
    {
        /// <summary>
        /// Get Public Risk
        /// </summary>
        /// <param name="value">value trade operation</param>
        /// <param name="parameterRisk">parameter to get risk type</param>
        /// <returns></returns>
        public string GetRisk ( double value , double parameterRisk )
        {
            if (value < parameterRisk)
            {
                return ConfigurationManager.AppSettings["LOWRISK"];
            }
            else
            {
                return ConfigurationManager.AppSettings["MEDIUMRISK"];
            }
        }
    }
}
