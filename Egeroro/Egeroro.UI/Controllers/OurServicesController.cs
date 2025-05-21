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
    public class OurServicesController : Controller
    {
        OurServicesManager _ourServicesManager = new OurServicesManager(new EFOurServicesDal());
        // GET: /<controller>/
        public IActionResult Index()
        {
            var result = _ourServicesManager.GetList();
            return View(result);
        }
        
        public IActionResult Detail(int id)
        {
            var service = _ourServicesManager.GetById(id);
            if (service == null)
            {
                return NotFound();
            }
            return View(service);
        }
    }
}

