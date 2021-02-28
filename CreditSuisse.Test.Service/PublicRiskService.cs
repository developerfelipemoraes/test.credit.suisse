﻿
using CreditSuisse.Test.Service.Interface;

namespace CreditSuisse.Test.Service
{
    public class PublicRiskService : ITradeRiskService
    {

        public string GetRisk ( double value , double parameterRisk )
        {
            if (value > parameterRisk)
            {
                return "XPTO";
            }else
            {
                return "XPTO-1";
            }
        }
    }
}