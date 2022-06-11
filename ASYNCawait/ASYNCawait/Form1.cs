using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASYNCawait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_normal_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            RunDownloadSync();

            watch.Stop();
            var elapseMs = watch.ElapsedMilliseconds;

            rtxt_results.Text += $"Total Execution time : {elapseMs}";
        }

        private void btn_async_Click(object sender, EventArgs e)
        {

        }

        private List<string> PrepData()
        {
            List<string> output = new List<string>();
            rtxt_results.Text = "";

            output.Add("https://www.yahoo.com");
            output.Add("https://www.google.com");
            output.Add("https://www.microsoft.com");
            output.Add("https://www.cnn.com");
            output.Add("https://www.codeproject.com");
            output.Add("https://www.stackoverflow.com");

            return output;
        }

        private void RunDownloadSync()
        {
            List<string> websites = PrepData();

            foreach (string item in websites)
            {
                WebsiteDataModel results = DownloadWebsite(item);
                ReportWebsiteInfo(results);
            }
        }
        private WebsiteDataModel DownloadWebsite(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            output.WebsiteUrl = websiteURL;
            output.WebsiteData = client.DownloadString(websiteURL);

            return output;
        }
        private void ReportWebsiteInfo(WebsiteDataModel data)
        {
            rtxt_results.Text += $"{ data.WebsiteUrl } downloaded: { data.WebsiteData.Length } characters long.{ Environment.NewLine }";
        }

    }
}
