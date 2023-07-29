using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.SendMessageDto;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Inbox() // listeleme metodu
        {
            var client = _httpClientFactory.CreateClient();
            var responserMessage = await client.GetAsync("http://localhost:5185/api/Contacts");
			var client2 = _httpClientFactory.CreateClient();
			var responserMessage2 = await client2.GetAsync("http://localhost:5185/api/Contacts/GetContactCount");
			var client3 = _httpClientFactory.CreateClient();
			var responserMessage3 = await client2.GetAsync("http://localhost:5185/api/SendMessage/SendMessagesCount");
			if (responserMessage.IsSuccessStatusCode)
            {
                var jsonData = await responserMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);
				var jsonData2 = await responserMessage2.Content.ReadAsStringAsync();
				ViewBag.contactCount = jsonData2;
				var jsonData3 = await responserMessage3.Content.ReadAsStringAsync();
				ViewBag.sendMessageCount = jsonData3;
				return View(values);
            }
 

			return View();

        }
        public async Task<IActionResult> SendBox() // listeleme metodu
        {
            var client = _httpClientFactory.CreateClient();
            var responserMessage = await client.GetAsync("http://localhost:5185/api/SendMessage");
			var client2 = _httpClientFactory.CreateClient();
			var responserMessage2 = await client2.GetAsync("http://localhost:5185/api/Contacts/GetContactCount");
			var client3 = _httpClientFactory.CreateClient();
			var responserMessage3 = await client2.GetAsync("http://localhost:5185/api/SendMessage/SendMessagesCount");
			if (responserMessage.IsSuccessStatusCode)
            {
                var jsonData = await responserMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSendBoxDto>>(jsonData);
				var jsonData2 = await responserMessage2.Content.ReadAsStringAsync();
				ViewBag.contactCount = jsonData2;
				var jsonData3 = await responserMessage3.Content.ReadAsStringAsync();
				ViewBag.sendMessageCount = jsonData3;
				return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateSendMessage createSendMessage)
        {
            createSendMessage.SenderMail = "admin@gmail.com";
            createSendMessage.SenderName = "admin";
            createSendMessage.Date = DateTime.Parse(DateTime.Now.ToShortDateString());


            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSendMessage);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5185/api/SendMessage", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SendBox");
            }

            else
            {
                return View();
            }
        }
        public async Task<PartialViewResult> SideBarAdminContactPartial()
        {

          
            return PartialView();
        }
        public PartialViewResult SideBarAdminContactCategoryPartial()
        {

            return PartialView();
        }
        public async Task<IActionResult> MessageDetailsBySendBox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5185/api/SendMessage/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetMessageByIdDto>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> MessageDetailsByInbox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5185/api/Contacts/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<InboxContactDto>(jsonData);
                return View(values);
            }
            return View();
        }


        //public async Task<IActionResult> GetContactCount() // listeleme metodu
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    var responserMessage = await client.GetAsync("http://localhost:5185/api/Contacts/GetContactCount");
        //    if (responserMessage.IsSuccessStatusCode)
        //    {
        //        var jsonData = await responserMessage.Content.ReadAsStringAsync();
        //        // var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);
        //        ViewBag.data = jsonData;
        //        return View();
        //    }
        //    return View();
        //}
    }
}
