using FGCSerbiaWeb.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FGCSerbiaWeb.Controllers
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
        public ActionResult Tournaments()
        {
            ViewBag.Message = "Your tournaments page.";

            return View();
        }
        //public ActionResult Twitch()
        //{
        //    ViewBag.Message = "Your twitch page.";

        //    return View();
        //}
        public ActionResult Meetups()
        {
            ViewBag.Message = "Your meetups page.";

            return View();
        }

        readonly string Baseurl = "https://api.twitch.tv/kraken/users/44322889?client_id=dyw2v1kn7zglk676f4pldux07apn4b";
        public async Task<ActionResult> Twitch()
        {
            var EmpInfo = new TwitchResponse();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.twitchtv.v5+json"));

                client.DefaultRequestHeaders.Add("Client-ID", "dyw2v1kn7zglk676f4pldux07apn4b");

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("OAuth", "ly3mc8y9bsjnsu0avaj5odzfkdjb46");

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("https://api.twitch.tv/helix/streams?user_login=gamesdonequick" +
                                                                                                   "&user_login=legendarymihawk" +
                                                                                                   "&user_login=superakouma");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    EmpInfo = JsonConvert.DeserializeObject<TwitchResponse>(EmpResponse);
                }
                //returning the employee list to view  
                return View(EmpInfo.data);
            }
        }
    }
}