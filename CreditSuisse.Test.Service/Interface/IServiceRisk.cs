using CreditSuisse.Test.Entitiy.Interface;
using System.Collections.Generic;

namespace CreditSuisse.Test.Service.Interface
{
    /// <summary>
    /// Interface of Service Risk
    /// </summary>
    public interface IServiceRisk
    {
        /// <summary>
        /// Get List of Trade Risc
        /// </summary>
        /// <param name="trades">Trades List</param>
        /// <returns>list of risk trades</returns>
        IList<string> GetRiskTrade(IList<ITrade> trades);
    }
}
