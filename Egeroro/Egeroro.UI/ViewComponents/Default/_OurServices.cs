using System;
using Egeroro.Business.Concrete;
using Egeroro.Data.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Egeroro.UI.ViewComponents.Default
{
    public class _OurServices : ViewComponent
    {
        OurServicesManager servicesManager = new OurServicesManager(new EFOurServicesDal());
        public IViewComponentResult Invoke()
        {
            var result = servicesManager.GetList();
            return View(result);
        }
        public _OurServices()
        {
        }
    }
}

