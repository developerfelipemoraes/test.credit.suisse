namespace CreditSuisse.Test.Service.Interface
{
    /// <summary>
    /// Interface of Trade Risk
    /// </summary>
    public interface  ITradeRiskService
    {
        /// <summary>
        /// Get Risk Trade
        /// </summary>
        /// <param name="value">value trade operation</param>
        /// <param name="parameterRisk">parameter to get risk type</param>
        /// <returns>Type Risk</returns>
        string GetRisk(double value, double limitingValueRisk);
    }
}
