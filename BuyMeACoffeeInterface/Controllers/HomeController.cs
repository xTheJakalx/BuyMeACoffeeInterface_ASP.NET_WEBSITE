using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace BuyMeACoffeeInterface.Controllers
{
    public partial class HomeController : Controller
    {
        // place your access_token in this variable
        // go here and login to get your API token
        // https://developers.buymeacoffee.com/dashboard
        private static string access_token = "change me to your token!";

        #region ActionResults (pages)
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetSubs()
        {
            var result = await GetActiveMembersAsync();
            return View(result);
        }
        public async Task<ActionResult> GetSubsById(int id)
        {
            var result = await GetMemberAsync(id);
            return View(result);
        }
        public async Task<ActionResult> GetSupporters()
        {
            var result = await GetSupportersAsync();
            return View(result);
        }
        public async Task<ActionResult> GetSupportersById(int id)
        {
            var result = await GetSupporterAsync(id);
            return View(result);
        }
        public async Task<ActionResult> GetExtras()
        {
            var result = await GetExtrasAsync();
            return View(result);
        }
        public async Task<ActionResult> GetExtrasById(int id)
        {
            var result = await GetExtraByIdAsync(id);
            return View(result);
        }

        #endregion

        #region Api Calls
        // These functions consume the BMC API and then convert the json to models
        // If you dont want models that fine change from TASK<Members> to TASK<string> 
        // and then you just need to use the data variable below

        /// <summary>
        /// Return a list of active Members as a model
        /// </summary>
        private async Task<Members> GetActiveMembersAsync()
        {
            if (access_token == "change me to your token!")
            {
                // have not changed the token so this function wont work!
                // returning an empty model so the razor pages dont crash!
                return new Members();
            }
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://developers.buymeacoffee.com/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
            HttpResponseMessage response = await client.GetAsync("/api/v1/subscriptions?status=active");
            if (response.IsSuccessStatusCode)
            {
                // return this variable if you just want a string
                var data = await response.Content.ReadAsStringAsync();
                // this vaiable converts the string to a model
                var result = JsonConvert.DeserializeObject<Members>(data);
                return result;
            }
            return null;
        }
        /// <summary>
        /// Return a single Members by id as a member model
        /// </summary>
        /// <param name="id">id of member to return</param>
        private async Task<Member> GetMemberAsync(int id)
        {
            if (access_token == "change me to your token!")
            {
                // have not changed the token so this function wont work!
                // returning an empty model so the razor pages dont crash!
                return new Member();
            }
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://developers.buymeacoffee.com/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
            HttpResponseMessage response = await client.GetAsync($"/api/v1/subscriptions/{id}");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Member>(data);
                return result;
            }
            return null;
        }
        /// <summary>
        /// Return a list of active Supporters as a model
        /// </summary>
        private async Task<Supporters> GetSupportersAsync()
        {
            if (access_token == "change me to your token!")
            {
                // have not changed the token so this function wont work!
                // returning an empty model so the razor pages dont crash!
                return new Supporters();
            }
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://developers.buymeacoffee.com/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
            HttpResponseMessage response = await client.GetAsync("/api/v1/supporters");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Supporters>(data);
                return result;
            }
            return null;
        }
        /// <summary>
        /// Return a single Supporter by id as a model
        /// </summary>
        /// <param name="id">id of supporter to return</param>
        private async Task<Supporter> GetSupporterAsync(int id)
        {
            if (access_token == "change me to your token!")
            {
                // have not changed the token so this function wont work!
                // returning an empty model so the razor pages dont crash!
                return new Supporter();
            }
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://developers.buymeacoffee.com/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
            HttpResponseMessage response = await client.GetAsync($"/api/v1/supporters/{id}");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Supporter>(data);
                return result;
            }
            return null;
        }

        /// <summary>
        /// Return a list of extra transactions as a model
        /// </summary>
        private async Task<Extras> GetExtrasAsync()
        {
            if (access_token == "change me to your token!")
            {
                // have not changed the token so this function wont work!
                // returning an empty model so the razor pages dont crash!
                return new Extras();
            }
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://developers.buymeacoffee.com/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
            HttpResponseMessage response = await client.GetAsync("/api/v1/extras");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Extras>(data);
                return result;
            }
            return null;
        }
        /// <summary>
        /// Return a single extra transaction by id as a model
        /// </summary>
        /// <param name="id">id of extra transaction to return</param>
        private async Task<ExtrasById> GetExtraByIdAsync(int id)
        {
            if (access_token == "change me to your token!")
            {
                // have not changed the token so this function wont work!
                // returning an empty model so the razor pages dont crash!
                return new ExtrasById();
            }
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://developers.buymeacoffee.com/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
            HttpResponseMessage response = await client.GetAsync($"/api/v1/extras/{id}");
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<ExtrasById>(data);
                return result;
            }
            return null;
        }

        #endregion
    }
}