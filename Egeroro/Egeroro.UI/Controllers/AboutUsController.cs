using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Egeroro.Business.Concrete;
using Egeroro.Data.EntityFramework;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Egeroro.UI.Controllers
{
	public class AboutUsController : Controller
	{
		AboutUsManager _aboutUsManager = new AboutUsManager(new EFAboutUsDal());


        // GET: /<controller>/
        public IActionResult Index()
		{
			var result = _aboutUsManager.GetList();
			return View(result);
		}
	}
}

