using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService ServiceService)
        {
            _serviceService = ServiceService;
        }

        [HttpGet] // verileri getirir
        public IActionResult ServiceList()
        {
            var values = _serviceService.TGetAll();
            return Ok(values);
        }
        [HttpPost] // verileri ekler
        public IActionResult AddService(Service service)
        {
            _serviceService.TInsert(service);

            return Ok();
        }
        [HttpDelete] //verileri siler
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.TGetByID(id);
            _serviceService.TDelete(values);
            return Ok();
        }
        [HttpPut]  //verileri günceller
        public IActionResult PutService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok();
        }
        [HttpGet("{id}")] // idye göre getirir
        public IActionResult GetService(int id)
        {
            var values = _serviceService.TGetByID(id);

            return Ok(values);
        }
    }
}
