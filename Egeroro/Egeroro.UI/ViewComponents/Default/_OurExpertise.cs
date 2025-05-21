using System;
using Egeroro.Business.Concrete;
using Egeroro.Data.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Egeroro.UI.ViewComponents.Default
{
	public class _OurExpertise : ViewComponent
	{
        OurExpertiseManager expertiseManager = new OurExpertiseManager(new EFOurExpertiseDal());
        public IViewComponentResult Invoke()
        {
            var result = expertiseManager.GetList();
            return View(result);
        }
    }
}

