namespace Stock_Price_by_Web
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAmountToInvestOrig = new System.Windows.Forms.TextBox();
            this.txtLotSize = new System.Windows.Forms.TextBox();
            this.txtNoOfShares = new System.Windows.Forms.TextBox();
            this.txtRiskPercentage = new System.Windows.Forms.TextBox();
            this.txtProfitPercentage = new System.Windows.Forms.TextBox();
            this.txtSellRate = new System.Windows.Forms.TextBox();
            this.btnGetPrice = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblStopLoss = new System.Windows.Forms.Label();
            this.txtStopLossRate = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnScript = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Symbol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Amount to Invest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lot Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. of Shares can Buy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Risk Percentage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Profit Percentage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sell Rate";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(137, 32);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(124, 20);
            this.txtSymbol.TabIndex = 8;
            this.txtSymbol.TextChanged += new System.EventHandler(this.txtSymbol_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(136, 65);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // txtAmountToInvestOrig
            // 
            this.txtAmountToInvestOrig.Location = new System.Drawing.Point(137, 94);
            this.txtAmountToInvestOrig.Name = "txtAmountToInvestOrig";
            this.txtAmountToInvestOrig.Size = new System.Drawing.Size(124, 20);
            this.txtAmountToInvestOrig.TabIndex = 10;
            // 
            // txtLotSize
            // 
            this.txtLotSize.Location = new System.Drawing.Point(137, 126);
            this.txtLotSize.Name = "txtLotSize";
            this.txtLotSize.Size = new System.Drawing.Size(124, 20);
            this.txtLotSize.TabIndex = 11;
            // 
            // txtNoOfShares
            // 
            this.txtNoOfShares.Location = new System.Drawing.Point(137, 160);
            this.txtNoOfShares.Name = "txtNoOfShares";
            this.txtNoOfShares.Size = new System.Drawing.Size(124, 20);
            this.txtNoOfShares.TabIndex = 12;
            // 
            // txtRiskPercentage
            // 
            this.txtRiskPercentage.Location = new System.Drawing.Point(136, 197);
            this.txtRiskPercentage.Name = "txtRiskPercentage";
            this.txtRiskPercentage.Size = new System.Drawing.Size(124, 20);
            this.txtRiskPercentage.TabIndex = 13;
            // 
            // txtProfitPercentage
            // 
            this.txtProfitPercentage.Location = new System.Drawing.Point(136, 229);
            this.txtProfitPercentage.Name = "txtProfitPercentage";
            this.txtProfitPercentage.Size = new System.Drawing.Size(124, 20);
            this.txtProfitPercentage.TabIndex = 14;
            // 
            // txtSellRate
            // 
            this.txtSellRate.Location = new System.Drawing.Point(137, 266);
            this.txtSellRate.Name = "txtSellRate";
            this.txtSellRate.Size = new System.Drawing.Size(124, 20);
            this.txtSellRate.TabIndex = 15;
            this.txtSellRate.TextChanged += new System.EventHandler(this.txtSellRate_TextChanged);
            // 
            // btnGetPrice
            // 
            this.btnGetPrice.Location = new System.Drawing.Point(296, 30);
            this.btnGetPrice.Name = "btnGetPrice";
            this.btnGetPrice.Size = new System.Drawing.Size(75, 23);
            this.btnGetPrice.TabIndex = 16;
            this.btnGetPrice.Text = "GetPrice";
            this.btnGetPrice.UseVisualStyleBackColor = true;
            this.btnGetPrice.Click += new System.EventHandler(this.btnGetPrice_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(186, 349);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(86, 349);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblStopLoss
            // 
            this.lblStopLoss.AutoSize = true;
            this.lblStopLoss.Location = new System.Drawing.Point(18, 306);
            this.lblStopLoss.Name = "lblStopLoss";
            this.lblStopLoss.Size = new System.Drawing.Size(80, 13);
            this.lblStopLoss.TabIndex = 19;
            this.lblStopLoss.Text = "Stop Loss Rate";
            this.lblStopLoss.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtStopLossRate
            // 
            this.txtStopLossRate.Location = new System.Drawing.Point(137, 299);
            this.txtStopLossRate.Name = "txtStopLossRate";
            this.txtStopLossRate.Size = new System.Drawing.Size(124, 20);
            this.txtStopLossRate.TabIndex = 20;
            this.txtStopLossRate.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(296, 76);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 21;
            this.lblError.Visible = false;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.btnScript);
            this.panel3.Controls.Add(this.lblError);
            this.panel3.Controls.Add(this.txtStopLossRate);
            this.panel3.Controls.Add(this.lblStopLoss);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnCalculate);
            this.panel3.Controls.Add(this.btnGetPrice);
            this.panel3.Controls.Add(this.txtSellRate);
            this.panel3.Controls.Add(this.txtProfitPercentage);
            this.panel3.Controls.Add(this.txtRiskPercentage);
            this.panel3.Controls.Add(this.txtNoOfShares);
            this.panel3.Controls.Add(this.txtLotSize);
            this.panel3.Controls.Add(this.txtAmountToInvestOrig);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.txtSymbol);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 387);
            this.panel3.TabIndex = 0;
            // 
            // btnScript
            // 
            this.btnScript.Location = new System.Drawing.Point(296, 72);
            this.btnScript.Name = "btnScript";
            this.btnScript.Size = new System.Drawing.Size(75, 23);
            this.btnScript.TabIndex = 22;
            this.btnScript.Text = "Script File";
            this.btnScript.UseVisualStyleBackColor = true;
            this.btnScript.Click += new System.EventHandler(this.btnScript_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 387);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Stock Price Calculator";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAmountToInvestOrig;
        private System.Windows.Forms.TextBox txtLotSize;
        private System.Windows.Forms.TextBox txtNoOfShares;
        private System.Windows.Forms.TextBox txtRiskPercentage;
        private System.Windows.Forms.TextBox txtProfitPercentage;
        private System.Windows.Forms.TextBox txtSellRate;
        private System.Windows.Forms.Button btnGetPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblStopLoss;
        private System.Windows.Forms.TextBox txtStopLossRate;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnScript;
    }
}

