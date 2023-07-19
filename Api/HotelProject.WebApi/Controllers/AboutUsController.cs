using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService _aboutUsService;
        public AboutUsController(IAboutUsService aboutService)
        {
            _aboutUsService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutUsService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAbout(AboutUs about)
        {
            _aboutUsService.TInsert(about);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutUsService.TGetByID(id);
            _aboutUsService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(AboutUs about)
        {
            _aboutUsService.TUpdate(about);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _aboutUsService.TGetByID(id);
            return Ok(values);
        }
    }
}
