using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessageCategoryController : ControllerBase
	{
		private readonly IMessageCategoryService _messageCategoryService;

		public MessageCategoryController(IMessageCategoryService messageCategoryService)
		{
			_messageCategoryService = messageCategoryService;
		}

		[HttpGet] // verileri getirir
		public IActionResult MessageCategoryList()
		{
			var values = _messageCategoryService.TGetAll();
			return Ok(values);
		}
		[HttpPost] // verileri ekler
		public IActionResult AddMessageCategory(MessageCategory messageCategory)
		{
			_messageCategoryService.TInsert(messageCategory);

			return Ok();
		}



		[HttpDelete("{id}")] //verileri siler
		public IActionResult DeleteMessageCategory(int id)
		{
			var values = _messageCategoryService.TGetByID(id);
			_messageCategoryService.TDelete(values);
			return Ok();
		}



		[HttpPut]  //verileri günceller
		public IActionResult PutMessageCategory(MessageCategory messageCategory)
		{
			_messageCategoryService.TUpdate(messageCategory);
			return Ok();
		}
		[HttpGet("{id}")] // idye göre getirir
		public IActionResult GetMessageCategory(int id)
		{
			var values = _messageCategoryService.TGetByID(id);

			return Ok(values);
		}
	}
}
