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
        int currArticle = -1;
        int totalArticles = 0;
        string[] newsArticles;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public class appnews {
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
            public string contents { get; set; }
            public string feedlabel { get; set; }
            public int date { get; set; }
            public string feedname { get; set; }

            public string toString()
            {
                var dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Math.Round(date / 1000d)).ToLocalTime();
                if (author == "" || author == null) {
                    return "" + title + "\r\n" + dt + "\r\n\r\n" + contents;
                } else
                {
                    return "" + title + "\r\n" + dt + "\r\nAuthor: " + author + "\r\n\r\n" + contents;
                }
            }
        }
        public class RootObject
        {
            public appnews appNews { get; set; }
        }

       

private void btnNext_Click(object sender, EventArgs e)
        {
            if (totalArticles >= 0)
            {
                if (currArticle == totalArticles - 1)
                {
                    currArticle = 0;
                } else
                {
                    currArticle = currArticle + 1;
                }
                txtNewsBox.Text = newsArticles[currArticle];
                labelPageNum.Text = (currArticle + 1) + "/" + totalArticles;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (totalArticles >= 0)
            {
                if (currArticle == 0)
                {
                    currArticle = totalArticles - 1;
                } else
                {
                    currArticle = currArticle - 1;
                }
                txtNewsBox.Text = newsArticles[currArticle];
                labelPageNum.Text = (currArticle + 1) + "/" + totalArticles;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //initaliazing gameId
                int gameId = 0;


                //SECOND REST -- SECOND REST -- SECOND REST -- SECOND REST -- SECOND REST -- SECOND REST -- 

                //getting id of game from input box
                gameId = int.Parse(txtGameId.Text);

                //client and request setup
                var client = new RestClient("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?");
                var request = new RestRequest();

                // Set up and build parameter list for this service
                //string key = "71897F1E822664717BC6FEFAE509510A";
                //request.AddParameter("api key", key);
                request.AddParameter("appid", gameId);
                request.AddParameter("count", "10"); //max amount of news articles to bring back
                request.AddParameter("maxlength", "900"); //max amount of characters taken from news article
                request.AddParameter("format", "json");

                // Service call
                var response = client.Execute(request);

                var deserializer = new JsonDeserializer();
                //setting up contents or response neatly
                var temp2 = new RootObject();
                temp2 = deserializer.Deserialize<RootObject>(response);
                var news = temp2.appNews.newsItems;

                newsArticles = new string[news.Count + 1];
                totalArticles = news.Count;
                currArticle = 0;

                for (int i = 0; i < news.Count; i++)
                {
                    newsArticles[i] = news[i].toString();
                }


                txtNewsBox.Text = newsArticles[currArticle];
                labelPageNum.Text = (currArticle + 1) + "/" + totalArticles;
            }
            catch (FormatException)
            {
                MessageBox.Show("Game ID must be number");
            }
            catch (NullReferenceException nullEx)
            {
                MessageBox.Show("No Game with that id");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
 }
    
