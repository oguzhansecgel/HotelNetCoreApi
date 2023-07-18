using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
namespace HotelProject.WebUI.Dtos.RegisterDto
{
	public class CreateNewUserDto
	{
		[System.ComponentModel.DataAnnotations.Required(ErrorMessage="Ad Alanı Gereklidir..!")]
		public string Name { get; set; }

		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Soyadı Alanı Gereklidir..!")]
		public string SurName { get; set; }

		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir..!")]
		public string UserName { get; set; }
		public string City { get; set; }

		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mail Alanı Gereklidir..!")]
		public string Mail { get; set; }

		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Şifre Alanı Gereklidir..!")]
		public string Password { get; set; }

		[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Şifre Tekrar Alanı Gereklidir..!")]
		[Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
		public string ConfirmPassword { get; set; }
	}
}
