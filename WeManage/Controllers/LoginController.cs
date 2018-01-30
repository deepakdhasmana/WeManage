using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using WeManage.Models;

namespace WeManage.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<string> Index(UserVerify data)
        {
            string un = data.UserName;
            string Password = data.Password;
            string Baseurl = "http://localhost:59713/";
            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                var Res = await client.GetAsync("api/UserLogins/AuthenticateUser?id=0&UserID=" + un + "&Password=" + Password);

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var LoginResponse = Res.Content.ReadAsStringAsync().Result;
                    var LoginInfo = JsonConvert.DeserializeObject<UserLogin>(LoginResponse);
                    return "1";
                }
                else
                {
                    return "-1";
                }
            }            
        }
    }    
}