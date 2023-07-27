using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SendMessageController : ControllerBase
	{
		private readonly ISendMessageService _sendMessageService;

		public SendMessageController(ISendMessageService sendMessageService)
		{
			_sendMessageService = sendMessageService;
		}

		[HttpGet] // verileri getirir
		public IActionResult MessageList()
		{
			var values = _sendMessageService.TGetAll();
			return Ok(values);
		}
		[HttpPost] // verileri ekler
		public IActionResult AddMessage(SendMessage sendMessage)
		{
			_sendMessageService.TInsert(sendMessage);

			return Ok();
		}



		[HttpDelete("{id}")] //verileri siler
		public IActionResult DeleteMessage(int id)
		{
			var values = _sendMessageService.TGetByID(id);
			_sendMessageService.TDelete(values);
			return Ok();
		}



		[HttpPut]  //verileri günceller
		public IActionResult PutMessage(SendMessage sendMessage)
		{
			_sendMessageService.TUpdate(sendMessage);
			return Ok();
		}
		[HttpGet("{id}")] // idye göre getirir
		public IActionResult GetMessage(int id)
		{
			var values = _sendMessageService.TGetByID(id);

			return Ok(values);
		}
		[HttpGet("SendMessagesCount")]
		public IActionResult GetSendMessageCount()
		{
			return Ok(_sendMessageService.TGetSendMessagesCount());
		}
	}
}
