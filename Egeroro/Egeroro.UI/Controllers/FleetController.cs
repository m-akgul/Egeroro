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
    public class FleetController : Controller
    {
        FleetManager _fleetManager = new FleetManager(new EFFleetDal());
        // GET: /<controller>/
        public IActionResult Index()
        {
            var result = _fleetManager.GetList();
            return View(result);
        }

        public IActionResult Detail(int id)
        {
            var service = _fleetManager.GetById(id);
            if (service == null)
            {
                return NotFound();
            }
            return View(service);
        }
    }
}

