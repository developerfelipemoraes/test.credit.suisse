using CreditSuisse.Test.Entitiy;
using CreditSuisse.Test.Entitiy.Interface;
using CreditSuisse.Test.Facede;
using System;
using System.Collections.Generic;

namespace CreditSuisse.Test
{
    public class Program
    {
        private static void Main()
        {
            try
            {
                Console.WriteLine($"Start process risk at {DateTime.Now}");

                IList<ITrade> trades = new List<ITrade>();

                IRiskFacede riskFacede = new RiskFacede();

                var trade1 = new Trade { Value = 2000000, ClientSector = "Private" };

                var trade2 = new Trade { Value = 400000, ClientSector = "Public" };

                var trade3 = new Trade { Value = 500000, ClientSector = "Public" };

                var trade4 = new Trade { Value = 3000000, ClientSector = "Public" };

                trades.Add(trade1);

                trades.Add(trade2);

                trades.Add(trade3);

                trades.Add(trade4);

                var riskResult = riskFacede.GetRiskTrade(trades);

                foreach (var risk in riskResult)
                {
                    Console.WriteLine(risk);
                }

                Console.WriteLine($"Finish process risk at {DateTime.Now}");

                Console.ReadLine();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.WriteLine(ex.StackTrace.ToString());
            }
           
        }
    }
}
