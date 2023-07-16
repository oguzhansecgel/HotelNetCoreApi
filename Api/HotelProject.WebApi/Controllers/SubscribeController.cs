using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService SubscribeService)
        {
            _subscribeService = SubscribeService;
        }

        [HttpGet] // verileri getirir
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.TGetAll();
            return Ok(values);
        }
        [HttpPost] // verileri ekler
        public IActionResult AddSubscribe(Subscriber subscribe)
        {
            _subscribeService.TInsert(subscribe);

            return Ok();
        }
        [HttpDelete] //verileri siler
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            _subscribeService.TDelete(values);
            return Ok();
        }
        [HttpPut]  //verileri günceller
        public IActionResult PutSubscribe(Subscriber subscribe)
        {
            _subscribeService.TUpdate(subscribe);
            return Ok();
        }
        [HttpGet("{id}")] // idye göre getirir
        public IActionResult GetSubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);

            return Ok(values);
        }
    }
}
