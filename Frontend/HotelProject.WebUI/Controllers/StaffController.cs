﻿using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class StaffController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public StaffController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index() // listeleme metodu
        {
			var client = _httpClientFactory.CreateClient();
			var responserMessage = await client.GetAsync("http://localhost:5185/api/Staff");
			if(responserMessage.IsSuccessStatusCode)
			{
				var jsonData = await responserMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(jsonData);
				return View(values);
			}
            return View();
        }
		[HttpGet]
		public IActionResult AddStaff()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> AddStaff(AddStaffViewModel model)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(model);
			StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
			var responseMessage = await client.PostAsync("http://localhost:5185/api/Staff",stringContent);
			if(responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			else
			{
				return View();
			}
		}
		public async Task<IActionResult> DeleteStaff(int id)
		{
            var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"http://localhost:5185/api/Staff/{id}");
			if(responseMessage.IsSuccessStatusCode) 
			{
				return RedirectToAction("Index");
			}
			return View();
        }
		[HttpGet]
		public async Task<IActionResult> UpdateStaff(int id)
		{
			var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5185/api/Staff/{id}");
			if(responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateStaffModel>(jsonData);
				return View(values);
			}
			return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateStaff(UpdateStaffModel model)
        {
            var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(model);
			StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync("http://localhost:5185/api/Staff/",stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}