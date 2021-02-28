using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.Test.Service.Interface
{
    public interface  ITradeRiskService
    {
        string GetRisk(double value, double limitingValueRisk);
    }
}
