using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text;
using imdb_dtdd.Models;
using Newtonsoft.Json;
using System.IO;

namespace imdb_dtdd.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(string name)
        {
            List<imdbModel> movie = SearchMovie(name);
            return View(movie);
        }

        private static List<imdbModel> SearchMovie(string name)
        {
            string apiUrl = "http://www.omdbapi.com/?apikey=3af9c9ea&t="+name;
            string result = null;

                HttpWebRequest reqobj = (HttpWebRequest)WebRequest.Create(apiUrl);
                reqobj.Method = "GET";
                reqobj.ContentType = "application/json;charset=utf-8";
                HttpWebResponse res = null;
                var response = (HttpWebResponse)reqobj.GetResponse();

                using (System.IO.Stream stream = (response.GetResponseStream()))
                {
                    StreamReader rd = new StreamReader(stream);

                    result = rd.ReadToEnd();

                List<imdbModel> movie = JsonConvert.DeserializeObject<List<imdbModel>>(result);

                rd.Close();

                    return movie;
                }
            }
        }
        
    
    }


