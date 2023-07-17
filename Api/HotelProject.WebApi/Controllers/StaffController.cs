using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet] // verileri getirir
        public IActionResult StaffList()
        {
            var values = _staffService.TGetAll();
            return Ok(values);
        }
        [HttpPost] // verileri ekler
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.TInsert(staff);
            
            return Ok();
        }



        [HttpDelete("{id}")] //verileri siler
        public IActionResult DeleteStaff(int id)
        {
            var values = _staffService.TGetByID(id);
            _staffService.TDelete(values);
            return Ok();
        }



        [HttpPut]  //verileri günceller
        public IActionResult PutStaff(Staff staff)
        {
            _staffService.TUpdate(staff);
            return Ok();
        }
        [HttpGet("{id}")] // idye göre getirir
        public IActionResult GetStaff(int id)
        {
            var values = _staffService.TGetByID(id);

            return Ok(values);
        }
    }
}
