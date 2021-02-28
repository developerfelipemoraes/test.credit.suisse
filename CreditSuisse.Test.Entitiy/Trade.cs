using CreditSuisse.Test.Entitiy.Interface;

namespace CreditSuisse.Test.Entitiy
{
    public class Trade : ITrade
    {
        public double Value { get; set; }

        public string ClientSector { get; set; }
    }
}
