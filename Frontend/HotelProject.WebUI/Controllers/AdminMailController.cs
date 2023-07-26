using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;

namespace HotelProject.WebUI.Controllers
{
	public class AdminMailController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(AdminMailViewModel model)
		{
			MimeMessage mimeMessage = new MimeMessage();
			
			//kim olacağı
			MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin","buraya kendi mailimiz");
			mimeMessage.From.Add(mailboxAddressFrom);

			//kime olacağı
			MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
			mimeMessage.To.Add(mailboxAddressTo);

			//mesaj içeriği
			var bodyBuilder = new BodyBuilder();
			bodyBuilder.TextBody = model.Body;
			mimeMessage.Body = bodyBuilder.ToMessageBody();

			//mesaj başlığı
			mimeMessage.Subject = model.Subject;

			SmtpClient client = new SmtpClient();
			client.Connect("smtp.gmail.com", 587,false);
			client.Authenticate("buraya kendi mailimiz", "google hesabından uygulama şifrelerinde şifre oluşturulup girilecek");
			client.Send(mimeMessage);
			client.Disconnect(true);

			return View();
		}
	}
}
