using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        [HttpGet] // verileri getirir
        public IActionResult RoomList()
        {
            return Ok();
        }
        [HttpPost] // verileri ekler
        public IActionResult AddRoom()
        {
            return Ok();
        }
        [HttpDelete] //verileri siler
        public IActionResult DeleteRoom() 
        {
            return Ok();
        }
        [HttpPut]  //verileri günceller
        public IActionResult PutRoom()
        {
            return Ok();
        }
        [HttpGet("{id}")] // idye göre getirir
        public IActionResult GetRoom() 
        {
            return Ok();
        }
    }
}
