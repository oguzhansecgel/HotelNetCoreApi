using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet] // verileri getirir
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetAll();
            return Ok(values);
        }
        [HttpPost] // verileri ekler
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);

            return Ok();
        }
        [HttpDelete("{id}")] //verileri siler
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            _bookingService.TDelete(values);
            return Ok();
        }
        [HttpPut("PutBooking")]  //verileri günceller
        public IActionResult PutBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpGet("{id}")] // idye göre getirir
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetByID(id);

            return Ok(values);
        }

        [HttpPut("aaaa")]
        public IActionResult aaaa(Booking booking)
        {
            _bookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }

		[HttpPut("bbbb")]
		public IActionResult bbbb(int id)
		{
			_bookingService.TBookingStatusChangeApproved2(id);
			return Ok();
		}
	}
}
