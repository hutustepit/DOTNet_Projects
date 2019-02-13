using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloWorldController : Controller
    {
		// GET: HelloWorld
		public string Index()
		{
			return "This is my default action...";
		}

		// 
		// GET: /HelloWorld/Welcome/ 

		public string Welcome(string name, int numTimes = 1)
		{
			return HttpUtility.HtmlEncode($"Hello {name}, NumTimes is: {numTimes}");
		}

	}
}