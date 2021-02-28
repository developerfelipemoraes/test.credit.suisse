namespace CreditSuisse.Test.UI
{
    partial class frmTrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlRisk = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblListTrades = new System.Windows.Forms.Label();
            this.btoRiskTrade = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.cmbClientSector = new System.Windows.Forms.ComboBox();
            this.lblClientType = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlRisk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRisk
            // 
            this.pnlRisk.Controls.Add(this.dataGridView2);
            this.pnlRisk.Controls.Add(this.button1);
            this.pnlRisk.Controls.Add(this.lblListTrades);
            this.pnlRisk.Controls.Add(this.dataGridView1);
            this.pnlRisk.Controls.Add(this.btoRiskTrade);
            this.pnlRisk.Controls.Add(this.txtValue);
            this.pnlRisk.Controls.Add(this.lblValue);
            this.pnlRisk.Controls.Add(this.cmbClientSector);
            this.pnlRisk.Controls.Add(this.lblClientType);
            this.pnlRisk.Location = new System.Drawing.Point(12, 22);
            this.pnlRisk.Name = "pnlRisk";
            this.pnlRisk.Size = new System.Drawing.Size(992, 657);
            this.pnlRisk.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(791, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get Result Trades Risk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblListTrades
            // 
            this.lblListTrades.AutoSize = true;
            this.lblListTrades.Location = new System.Drawing.Point(29, 100);
            this.lblListTrades.Name = "lblListTrades";
            this.lblListTrades.Size = new System.Drawing.Size(59, 13);
            this.lblListTrades.TabIndex = 6;
            this.lblListTrades.Text = "Trades List";
            // 
            // btoRiskTrade
            // 
            this.btoRiskTrade.Location = new System.Drawing.Point(654, 28);
            this.btoRiskTrade.Name = "btoRiskTrade";
            this.btoRiskTrade.Size = new System.Drawing.Size(157, 30);
            this.btoRiskTrade.TabIndex = 4;
            this.btoRiskTrade.Text = "Add Trade";
            this.btoRiskTrade.UseVisualStyleBackColor = true;
            this.btoRiskTrade.Click += new System.EventHandler(this.btoRiskTrade_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(413, 34);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(201, 20);
            this.txtValue.TabIndex = 3;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(372, 36);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value";
            // 
            // cmbClientSector
            // 
            this.cmbClientSector.FormattingEnabled = true;
            this.cmbClientSector.Items.AddRange(new object[] {
            "Private",
            "Public"});
            this.cmbClientSector.Location = new System.Drawing.Point(92, 34);
            this.cmbClientSector.Name = "cmbClientSector";
            this.cmbClientSector.Size = new System.Drawing.Size(242, 21);
            this.cmbClientSector.TabIndex = 1;
            // 
            // lblClientType
            // 
            this.lblClientType.AutoSize = true;
            this.lblClientType.Location = new System.Drawing.Point(26, 37);
            this.lblClientType.Name = "lblClientType";
            this.lblClientType.Size = new System.Drawing.Size(67, 13);
            this.lblClientType.TabIndex = 0;
            this.lblClientType.Text = "Client Sector";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 323);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(794, 128);
            this.dataGridView2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 128);
            this.dataGridView1.TabIndex = 5;
            // 
            // frmTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 708);
            this.Controls.Add(this.pnlRisk);
            this.Name = "frmTrade";
            this.Text = "Trade Credit Suisse";
            this.pnlRisk.ResumeLayout(false);
            this.pnlRisk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRisk;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ComboBox cmbClientSector;
        private System.Windows.Forms.Label lblClientType;
        private System.Windows.Forms.Button btoRiskTrade;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblListTrades;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

