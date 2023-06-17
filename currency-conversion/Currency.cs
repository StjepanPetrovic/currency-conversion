using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency_conversion
{
    internal class Currency
    {
        public string Name { get; set; }
        public double ExchangeRate { get; set; }

        public static double ConvertTo(Currency currency1, Currency currency2, double amount)
        {
            double convertedAmount = amount * (currency1.ExchangeRate / currency2.ExchangeRate);

            return convertedAmount;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
