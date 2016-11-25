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
            try {
                //getting id of game from input box
                int gameId = 0;
                try
                {
                    gameId = int.Parse(txtGameId.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Game ID must be number");
                }

                var client = new RestClient("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?");
                var request = new RestRequest();

                // Set up and build parameter list for this service
                //string key = "71897F1E822664717BC6FEFAE509510A";
                //request.AddParameter("api key", key);
                request.AddParameter("appid", gameId);
                request.AddParameter("count", "3");
                request.AddParameter("maxlength", "300");
                request.AddParameter("format", "json");

                // Service call
                var response = client.Execute(request);


                JsonDeserializer deserializer = new JsonDeserializer();

                var temp = new RootObject();
                temp = deserializer.Deserialize<RootObject>(response);
                var news = temp.appNews.newsItems;

                foreach (newsitems n in news)
                {
                    MessageBox.Show(n.contents);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        public class appnews{
            public int appid { get; set; }
            public List<newsitems> newsItems { get; set; }
        }

        public class newsitems
        {
            public string gid { get; set; }
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
