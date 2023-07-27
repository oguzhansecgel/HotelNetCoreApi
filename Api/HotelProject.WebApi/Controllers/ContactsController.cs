using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactsService _contactsService;

        public ContactsController(IContactsService contactsService)
        {
            _contactsService = contactsService;
        }

		[HttpGet] // verileri getirir
		public IActionResult ContactList()
		{
			var values = _contactsService.TGetAll();
			return Ok(values);
		}
		[HttpPost] // verileri ekler
        public IActionResult AddContact(Contacts contacts)
        {
            contacts.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactsService.TInsert(contacts);
            return Ok();
        }
        [HttpGet("{id}")] // idye göre getirir
        public IActionResult GetMessage(int id)
        {
            var values = _contactsService.TGetByID(id);

            return Ok(values);
        }
        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount(int id) 
        {
           return Ok(_contactsService.TGetContactCount());
        }
    }
}
