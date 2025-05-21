using System;
using Egeroro.Business.Concrete;
using Egeroro.Data.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Egeroro.UI.ViewComponents.Default
{
	public class _OurTeam : ViewComponent
	{
        OurTeamManager teamManager = new OurTeamManager(new EFOurTeamDal());
        public IViewComponentResult Invoke()
        {
            var result = teamManager.GetList();
            return View(result);
        }
    }
}

