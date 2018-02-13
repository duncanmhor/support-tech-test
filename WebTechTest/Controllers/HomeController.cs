using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebTechTest.Models;
using WebTechTest.Models.Nestoria;

namespace WebTechTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public  async Task<ActionResult> Index(NestoriaSearchViewModel searchViewModel)
        {
            string baseUri =
                @"https://api.nestoria.co.uk/api?country=uk&pretty=1&encoding=json&listing_type=buy&action=search_listings&page=1&place_name=";
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(baseUri + searchViewModel.SearchTerm);
                if (response.Result.StatusCode == HttpStatusCode.OK)
                {
                    searchViewModel.ApiCallRootObject =
                        JsonConvert.DeserializeObject<RootObject>(await response.Result.Content.ReadAsStringAsync());
                }
            }

            return View(searchViewModel);
        }
    }
}