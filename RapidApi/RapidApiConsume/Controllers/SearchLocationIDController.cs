using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http.Headers;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationIDController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
             
            if(!string.IsNullOrEmpty(cityName))
            {
                List<BookingApiLocationSearchVM> bookingApiLocationSearchVMs = new List<BookingApiLocationSearchVM>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name="+cityName+"&locale=en-gb"),
                    Headers =
    {
        { "X-RapidAPI-Key", "e681a8fe6bmsh28d44ee13cf1bbdp1a2f51jsn5b8848d71132" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    bookingApiLocationSearchVMs = JsonConvert.DeserializeObject<List<BookingApiLocationSearchVM>>(body);
                    return View(bookingApiLocationSearchVMs.Take(1).ToList());

                }
            }
            else
            {
                List<BookingApiLocationSearchVM> bookingApiLocationSearchVMs = new List<BookingApiLocationSearchVM>();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=Paris&locale=en-gb"),
                    Headers =
    {
        { "X-RapidAPI-Key", "e681a8fe6bmsh28d44ee13cf1bbdp1a2f51jsn5b8848d71132" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    bookingApiLocationSearchVMs = JsonConvert.DeserializeObject<List<BookingApiLocationSearchVM>>(body);
                    return View(bookingApiLocationSearchVMs.Take(1).ToList());

                }
            }
        }
    }
}
