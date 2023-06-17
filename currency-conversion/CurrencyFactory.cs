using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currency_conversion
{
    internal class CurrencyFactory
    {
        public List<Currency> CurrencyList { get; set; } = new List<Currency> 
        {
            new Currency
            {
                Name = "HRK",
                ExchangeRate = 1f
            },

            new Currency
            {
                Name = "EUR",
                ExchangeRate = 7.4
            },

            new Currency
            {
                Name = "USD",
                ExchangeRate = 6.5
            },

            new Currency
            {
                Name = "GBP",
                ExchangeRate = 8.5
            },

            new Currency
            {
                Name = "CAD",
                ExchangeRate = 4.9
            }
        };

        public Currency GetCurrency(string currName)
        {
            return CurrencyList.Find(currency => currency.Name == currName);
        }
    }
}
