using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using RestSharp;
using RestSharp.Deserializers;

namespace testSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?");
            var request = new RestRequest();

            // Set up and build parameter list for this service

            //string Myuser = "test";
            //string myMethod = "user.getTopArtists";
            //request.AddParameter("method", myMethod);
            //request.AddParameter("user", Myuser);
            //string myKey = "581cca30b41a4cc0d5b3eb59d502b651";
            //request.AddParameter("api_key", myKey);
            //request.AddParameter("limit", 10);
            //request.AddParameter("format", "json");
            //string key = "71897F1E822664717BC6FEFAE509510A";
            //request.AddParameter("api key", key);
            request.AddParameter("appid", "440");
            request.AddParameter("count", "3");
            request.AddParameter("maxlength", "300");
            request.AddParameter("format", "json");

            // Service call

            var response = client.Execute(request);


            JsonDeserializer deserializer = new JsonDeserializer();

            // have a look at the structure of the json

            MessageBox.Show(response.Content);

            var temp = deserializer.Deserialize<RootObject>(response); 

        }

        public class appnews{
            public int appid { get; set; }
            public List<newsitems> newsItems { get; set; }
        }

        public class newsitems
        {
            public int gid { get; set; }
            public string title { get; set; }
            public string url { get; set; }
            public Boolean is_external_url { get; set; }
            public string author { get; set; }
            public string  contents { get; set; }
            public string feedlabel { get; set; }
            public int date { get; set; }
            public string feedname { get; set; }

    }
        public class RootObject
        {
            public appnews appNews { get; set; }
        }
    }
}
