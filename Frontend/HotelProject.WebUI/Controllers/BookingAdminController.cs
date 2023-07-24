using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
	public class BookingAdminController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public BookingAdminController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index() // listeleme metodu
		{
			var client = _httpClientFactory.CreateClient();
			var responserMessage = await client.GetAsync("http://localhost:5185/api/Booking");
			if (responserMessage.IsSuccessStatusCode)
			{
				var jsonData = await responserMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
				return View(values);
			}
			return View();
		}
		public async Task<IActionResult> ApprovedReservation(ApprovedReservastionDto approvedReservastionDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(approvedReservastionDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("http://localhost:5185/api/Booking/", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{

				return RedirectToAction("Index");
			}
			return View();
		}
 
	}
}
