using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Price_by_Web
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> target = new Dictionary<string, string>(); // store comma seperated script and target price on startup
        Dictionary<string, string> checkPrice = new Dictionary<string, string>(); // store comma seperated script and current price on startup
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetPrice_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
           
            if (!String.IsNullOrEmpty(txtSymbol.Text))
            {
                String urlAddress = @"https://dps.psx.com.pk/company/" + txtSymbol.Text.ToUpper();

                txtPrice.Text = GetPrice(urlAddress);




            }
        }

        #region helper methods
        private void SetError(string v)
        {
            lblError.Text = v;
            lblError.Visible = true;
            lblError.ForeColor = System.Drawing.Color.Red;
        }

        private bool ValidateInput()
        {
            if (String.IsNullOrEmpty(txtAmountToInvestOrig.Text) || String.IsNullOrEmpty(txtLotSize.Text) ||
                 String.IsNullOrEmpty(txtPrice.Text) || String.IsNullOrEmpty(txtProfitPercentage.Text) ||
                 String.IsNullOrEmpty(txtRiskPercentage.Text))
            {
                return false;
            }
            else
            {

                return true;
            }

        }

        private string GetPrice(string urlAddress)
        {
            string finalPrice="";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = response.GetResponseStream();
                    StreamReader readStream = null;

                    if (String.IsNullOrWhiteSpace(response.CharacterSet))
                        readStream = new StreamReader(receiveStream);
                    else
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

                    string data = readStream.ReadToEnd();


                    response.Close();
                    readStream.Close();
                    string keyword = "<div class=\"quote__close\">";

                    string price = data.Substring(data.IndexOf("<div class=\"quote__price\">") + (keyword.Length * 2), 40);
                    int fPrice = price.IndexOf('<');
                     finalPrice = price.Substring(0, fPrice); //price in rupee symbol
                    //finalPrice = finalPrice.Substring(3);                    
                    return finalPrice;
                }
                else
                {
                    SetError("No seurity found");
                    return "";
                }
            }
            catch (Exception)
            {
                SetError("No seurity found");

                return "";
            }

        }

        private void ClearAllTextBoxes()
        {
            txtLotSize.Text = txtNoOfShares.Text = txtPrice.Text = txtSellRate.Text = txtStopLossRate.Text = "";
            lblError.Visible = false;
        }
        #endregion
        //To do
        /*
         * Save target buy price in file and check everyday every hour if target buy price is met
         * KAPCO,24.40
         * TRG,40.55
         * if traget price is met create a file containing 
         * scriptname,current price,target price
             
             */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                double amout = System.Convert.ToDouble(txtAmountToInvestOrig.Text);
                double price = System.Convert.ToDouble(txtPrice.Text.Substring(txtPrice.Text.IndexOf("Rs.") + 3));
                int lotSize = System.Convert.ToInt32(txtLotSize.Text);
                double profitPercent = System.Convert.ToUInt32(txtProfitPercentage.Text);
                double RiskPercent = System.Convert.ToUInt32(txtRiskPercentage.Text);


                double noOfShares = Math.Floor((amout / price) / lotSize) * lotSize;
                txtNoOfShares.Text = noOfShares.ToString();
                if (noOfShares == 0)
                {
                    SetError("Can not buy");
                }
                else
                {
                    double actualAmount = noOfShares * price;
                    txtAmountToInvestOrig.Text = actualAmount.ToString();

                    double SellRate = ((actualAmount / 100) * profitPercent + actualAmount) / noOfShares;
                    txtSellRate.Text = SellRate.ToString();

                    double stopLoss = (actualAmount - (actualAmount / 100) * RiskPercent) / noOfShares;
                    txtStopLossRate.Text = stopLoss.ToString();
                }

            }
        }

     
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSellRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSymbol_TextChanged(object sender, EventArgs e)
        {
            string text = txtSymbol.Text;
            bool alpha = true;
            foreach (char letter in text)
            {

                if (!char.IsLetter(letter))
                {
                    alpha = false;
                    break;
                }
            }
            // Call SetError or Clear on the ErrorProvider.
            if (!alpha)
            {
                errorProvider1.SetError(txtSymbol, "Should be Letters only");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnScript_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.ShowDialog();

            filePath = openFileDialog.FileName;

            if (!string.IsNullOrEmpty(filePath))
            {
                string[] scripts;

                 scripts = File.ReadAllLines(filePath);

                
                foreach (var item in scripts)
                {
                    if (!string.IsNullOrEmpty(item))
                    {
                        var scr = item.Split(',');

                        String urlAddress = @"https://dps.psx.com.pk/company/" + scr[0].ToUpper();
                        checkPrice.Add(scr[0].ToUpper(), GetPrice(urlAddress));
                       

                    }
                }
                
            }
        }
    }
}
