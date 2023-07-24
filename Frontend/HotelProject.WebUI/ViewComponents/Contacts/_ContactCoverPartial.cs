using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Contacts
{
	public class _ContactCoverPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
