using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace imdbdtdd2
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string movieinput = inputmovie.Text.ToString();
                string apiUrl = "http://www.omdbapi.com/?apikey=3af9c9ea&t=" + movieinput;
                Uri apiUri = new Uri(apiUrl);
                WebRequest requestObj = WebRequest.Create(apiUri);
                requestObj.Method = "GET";
                HttpWebResponse responseObj = null;
                responseObj = (HttpWebResponse)requestObj.GetResponse();
                string result = null;

                using (Stream stream = responseObj.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    result = sr.ReadToEnd();
                    var listres = JsonConvert.DeserializeObject<imdbModel>(result);
                    sr.Close();


                    foreach(var item in result)
                {
                    lblname.Text = listres.title;
                    imgposter.ImageUrl = listres.poster;
                    lblyear.Text = listres.released;
                    lblrated.Text = listres.rated;
                    lblactors.Text = listres.actors;
                    lbldirector.Text = listres.director;
                    lblplot.Text = listres.plot;
                }
            }
            }
            
            
                
        }
    }
