using CreditSuisse.Test.Entitiy;
using CreditSuisse.Test.Entitiy.Interface;
using CreditSuisse.Test.Facede;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CreditSuisse.Test.UI
{
    public partial class frmTrade : Form
    {
        private IList<ITrade> Trades = new List<ITrade>();

        public frmTrade()
        {
            InitializeComponent();
        }

        private void btoRiskTrade_Click(object sender, EventArgs e)
        {
            try
            {
                IRiskFacede riskFacede = new RiskFacede();

                double value = 0.00;

                Double.TryParse(txtValue.Text.ToString(), out value);

                if (value == 0)
                {
                    MessageBox.Show("The value must be greater than zero, and cannot contain letters and special characters.");
                }

                var trade = new Trade
                {
                    Value = Convert.ToDouble(value),
                    ClientSector = cmbClientSector.SelectedItem.ToString()
                };

                Trades.Add(trade);

                var bindingList = new BindingList<ITrade>(Trades);

                var source = new BindingSource(bindingList, null);

                dataGridView1.DataSource = source;

                dataGridView1.Refresh();

                txtValue.Text = string.Empty;

                cmbClientSector.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IRiskFacede riskFacede = new RiskFacede();

                var resultRisk = riskFacede.GetRiskTrade(this.Trades);

                dataGridView2.DataSource = resultRisk.Select(x => new { Value = x }).ToList(); ;

                dataGridView2.Refresh();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
