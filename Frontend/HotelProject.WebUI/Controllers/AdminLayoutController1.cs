﻿using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController1 : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }
        public PartialViewResult HeadPartile()
        {
            return PartialView();
        }
        public PartialViewResult PreLoaderPartile() 
        {
            return PartialView();
        }
        public PartialViewResult NavHeaderPartial()
        {
            return PartialView();
        }
		public PartialViewResult HeaderPartial()
		{
			return PartialView();
		}
		public PartialViewResult SideBarPartial()
		{
			return PartialView();
		}
		public PartialViewResult FooterPartial()
		{
			return PartialView();
		}
        public PartialViewResult ScriptPartial()
		{
			return PartialView();
		}
	}
}