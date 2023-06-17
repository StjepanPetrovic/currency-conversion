using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currency_conversion
{
    public partial class MoneyConverterForm : Form
    {
        CurrencyFactory currencyFactory = new CurrencyFactory();

        public MoneyConverterForm()
        {
            InitializeComponent();

            cbFirstCurrency.BindingContext = new BindingContext();
            cbFirstCurrency.DataSource = currencyFactory.CurrencyList;

            cbSecondCurrency.BindingContext = new BindingContext();
            cbSecondCurrency.DataSource = currencyFactory.CurrencyList;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string firstCurrenyName = cbFirstCurrency.SelectedItem.ToString();
            string secondCurrenyName = cbSecondCurrency.SelectedItem.ToString();

            double amount = double.Parse(txtAmount.Text);
        
            Currency firstCurrency = currencyFactory.GetCurrency(firstCurrenyName);
            Currency secondCurrency = currencyFactory.GetCurrency(secondCurrenyName);

            double convertedAmount = Currency.ConvertTo(firstCurrency, secondCurrency, amount);

            ShowResult(convertedAmount);
        }

        public void ShowResult(double convertedAmount)
        {
            txtConvertedAmount.Text = convertedAmount.ToString();
        }
    }
}
