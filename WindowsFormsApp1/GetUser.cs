using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	class GetUser
	{
		public GetUser(ListBox lb, Label lbl1, Label lbl2)
		{
			listBox1 = lb;
			label1 = lbl1;
			label2 = lbl2;
		}

		public ListBox listBox1 { get; private set; }
		public Label label2 { get; private set; }
		public Label label1 { get; private set; }

		public class IpProperties
		{
			public string Status { get; set; }
			public string Country { get; set; }
			public string CountryCode { get; set; }
			public string Region { get; set; }
			public string RegionName { get; set; }
			public string City { get; set; }
			public string Zip { get; set; }
			public string Lat { get; set; }
			public string Lon { get; set; }
			public string TimeZone { get; set; }
			public string ISP { get; set; }
			public string ORG { get; set; }
			public string AS { get; set; }
			public string Query { get; set; }
		}
		public string IPRequestHelper(string url)
		{
			HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
			HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();

			StreamReader responseStream = new StreamReader(objResponse.GetResponseStream());
			string responseRead = responseStream.ReadToEnd();

			responseStream.Close();
			responseStream.Dispose();

			return responseRead;
		}

		public void GetCountryByIP(string ipAddress)
		{
			try {

				string ipResponse = IPRequestHelper("http://ip-api.com/xml/" + ipAddress);
				using (TextReader sr = new StringReader(ipResponse))
				{
					using (System.Data.DataSet dataBase = new System.Data.DataSet())
					{
						IpProperties ipProperties = new IpProperties();
						dataBase.ReadXml(sr);
						listBox1.Items.Clear();
						listBox1.Items.Add("Status: " + (ipProperties.Status = dataBase.Tables[0].Rows[0][0].ToString()));
						listBox1.Items.Add("Country: " + (ipProperties.Country = dataBase.Tables[0].Rows[0][1].ToString()));
						listBox1.Items.Add("CountryCode: " + (ipProperties.CountryCode = dataBase.Tables[0].Rows[0][2].ToString()));
						listBox1.Items.Add("Region: " + (ipProperties.Region = dataBase.Tables[0].Rows[0][3].ToString()));
						//listBox1.Items.Add("");
						listBox1.Items.Add("RegionName: " + (ipProperties.RegionName = dataBase.Tables[0].Rows[0][4].ToString()));
						listBox1.Items.Add("City: " + (ipProperties.City = dataBase.Tables[0].Rows[0][5].ToString()));
						listBox1.Items.Add("ZIP: " + (ipProperties.Zip = dataBase.Tables[0].Rows[0][6].ToString()));
						label1.Text = ipProperties.Lat = dataBase.Tables[0].Rows[0][7].ToString();
						label2.Text = ipProperties.Lon = dataBase.Tables[0].Rows[0][8].ToString();
						listBox1.Items.Add("LAT: " + (ipProperties.Lat = dataBase.Tables[0].Rows[0][7].ToString()));
						listBox1.Items.Add("LON: " + (ipProperties.Lon = dataBase.Tables[0].Rows[0][8].ToString()));
						listBox1.Items.Add("TimerZone: " + (ipProperties.TimeZone = dataBase.Tables[0].Rows[0][9].ToString()));
						listBox1.Items.Add("ISP: " + (ipProperties.ISP = dataBase.Tables[0].Rows[0][10].ToString()));
						listBox1.Items.Add("ORG: " + (ipProperties.ORG = dataBase.Tables[0].Rows[0][11].ToString()));
						listBox1.Items.Add("AS: " + (ipProperties.AS = dataBase.Tables[0].Rows[0][12].ToString()));
						listBox1.Items.Add("QUERY: " + (ipProperties.Query = dataBase.Tables[0].Rows[0][13].ToString()));




					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}

