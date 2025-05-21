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
    public class ContactController : Controller
    {
        ContactManager _contactManager = new ContactManager(new EFContactDal());

        // GET: /<controller>/
        public IActionResult Index()
        {
            var result = _contactManager.GetList();
            return View(result);
        }
    }
}

