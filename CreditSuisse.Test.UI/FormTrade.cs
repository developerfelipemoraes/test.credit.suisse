using CreditSuisse.Test.Entitiy;
using CreditSuisse.Test.Entitiy.Interface;
using CreditSuisse.Test.Facede;
using System;
using System.Collections.Generic;
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
            
            IRiskFacede riskFacede = new RiskFacede();

            var trade = new Trade {
                Value = Convert.ToDouble (txtValue.Text.ToString()), 
                ClientSector = cmbClientSector.SelectedItem.ToString() 
            };
            Trades.Add(trade);
            dataGridView1.DataSource = Trades;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IRiskFacede riskFacede = new RiskFacede();

            var resultRisk = riskFacede.GetRiskTrade(this.Trades);

            dataGridView2.DataSource = resultRisk;
        }
    }
}
