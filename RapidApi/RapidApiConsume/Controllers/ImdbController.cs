﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http.Headers;

namespace RapidApiConsume.Controllers
{
	public class ImdbController : Controller
	{
		public async Task<IActionResult> Index()
		{
			List<ApiMovieViewModel> apiMovieViewModels = new List<ApiMovieViewModel>();
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://imdb-top-100-movies1.p.rapidapi.com/"),
				Headers =
	{
		{ "X-RapidAPI-Key", "e681a8fe6bmsh28d44ee13cf1bbdp1a2f51jsn5b8848d71132" },
		{ "X-RapidAPI-Host", "imdb-top-100-movies1.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				apiMovieViewModels = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
				return View(apiMovieViewModels);
 
			}
 
		}
	}
}
