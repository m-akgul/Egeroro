using System;
using Egeroro.Business.Concrete;
using Egeroro.Data.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Egeroro.UI.ViewComponents.Default
{
	public class _FleetDropdown : ViewComponent
	{
		FleetManager fleetManager = new FleetManager(new EFFleetDal());
        public IViewComponentResult Invoke()
        {
            var result = fleetManager.GetList();
            return View(result);
        }
    }
}

