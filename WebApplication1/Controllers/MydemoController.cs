//using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MydemoController : Controller
    {
        // GET: Mydemo
        public ActionResult Index()


        {
            return View();
        }


		[Route("")]
		[Route("Demo")]
		[Route("Demo/Index")]
		public ActionResult MyIndex()
		{
			return View("Index");
		}
		[Route("Home/About")]
		public ActionResult MyAbout()
		{
			return View();
		}
		[Route("Home/Contact")]
		public ActionResult MyContact()
		{
			return View("Contact");
		}

		public ActionResult Article(int id)
		{
			ViewData["id"] = id;
			//HttpUtility.HtmlEncode($"Hello {name} ", )
			if(id  == 6)
			{
				return View();
			}
			else if(id ==9)
			{
				return RedirectToAction("Index", "Home");
			}
			return View();
		}

		public ActionResult Bogdi(int id)


		{
			ViewData["numlines"] = id;
			return View();
		}
	}
}