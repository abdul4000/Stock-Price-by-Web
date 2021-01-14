using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Price_by_Web
{
   public class Portfolio
    {
        public int quantity;
        public string name;
        public string price;
        public string avgPrice;
        public List<Stocks> Stocks;
        



        public Portfolio(string name, string price)
        {
            this.name = name;
            this.price = price;
        }
        public Portfolio()
        {
            Stocks = new List<Stocks>();
        }

        public void GetStockPriceFromFile()
        {
            List<string> stocksName = new List<string>();
            stocksName.Add("DGKC");
            stocksName.Add("MLCF");


        }

        public Dictionary<string, string> FetchPriceFromWeb(List<string> stocksName)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            String urlAddress = "";
            foreach (var item in stocksName)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    urlAddress = @"https://dps.psx.com.pk/company/" + item.ToUpper();
                    result.Add(item, GetPrice(urlAddress));
                }


            }
            return result;

        }
        private string GetPrice(string urlAddress)
        {
            string finalPrice = "";
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
                    finalPrice = finalPrice.Substring(3);
                    return finalPrice;
                }
                else
                {
                    Console.WriteLine("No seurity found");
                    return "";
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No seurity found");

                return "";
            }

        }
    }
}
