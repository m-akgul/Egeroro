using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Egeroro.Business.Concrete;
using Egeroro.Data.EntityFramework;
using Egeroro.Entity.Concrete;
using Egeroro.Entity.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Egeroro.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        AboutUsManager _aboutUsManager = new AboutUsManager(new EFAboutUsDal());
        OurServicesManager _ourServicesManager = new OurServicesManager(new EFOurServicesDal());
        FleetManager _fleetManager = new FleetManager(new EFFleetDal());
        GalleryManager _galleryManager = new GalleryManager(new EFGalleryDal());
        ContactManager _contactManager = new ContactManager(new EFContactDal());

        public AdminController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var result = _aboutUsManager.GetList();
            return View(result);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.Name != null)
            {
                if (User.Identity?.IsAuthenticated == true)
                {
                    return RedirectToAction("Index", "Admin");
                }
            }
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(string UserName, string Password)
        {
            var User = await _userManager.FindByNameAsync(UserName);
            if (User != null)
            {
                var sonuc = await _signInManager.PasswordSignInAsync(UserName, Password, false, true);
                if (sonuc.Succeeded)
                {
                    return RedirectToAction("Index", "Admin");
                }
            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult EditAboutUs(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Home", "Error");
            }
            var aboutUs = _aboutUsManager.GetById(Convert.ToInt32(id));
            if (aboutUs == null)
            {
                return RedirectToAction("Home", "Error");
            }
            return View(aboutUs);
        }
        [HttpPost]
        public IActionResult EditAboutUs(AboutUs aboutUs)
        {
            if (ModelState.IsValid)
            {
                _aboutUsManager.AboutUsUpdate(aboutUs);
                return RedirectToAction(nameof(Index));
            }
            return View(aboutUs);
        }

        public IActionResult OurServices(int id)
        {
            var result = _ourServicesManager.GetList();
            return View(result);
        }
        [HttpGet]
        public IActionResult EditOurServices(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Home", "Error");
            }
            var ourServices = _ourServicesManager.GetById(Convert.ToInt32(id));
            if (ourServices == null)
            {
                return RedirectToAction("Home", "Error");
            }
            return View(ourServices);
        }
        [HttpPost]
        public IActionResult EditOurServices(OurServices ourServices)
        {
            if (ModelState.IsValid)
            {
                _ourServicesManager.OurServicesUpdate(ourServices);
                return RedirectToAction(nameof(OurServices));
            }
            return View(ourServices);
        }
        [HttpGet]
        public IActionResult AddOurServices()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOurServices(OurServices ourServices)
        {
            if (ModelState.IsValid)
            {
                _ourServicesManager.OurServicesInsert(ourServices);
                return RedirectToAction(nameof(OurServices));
            }
            return View(ourServices);
        }
        [HttpGet]
        public IActionResult DeleteOurServices(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Home", "Error");
            }
            var ourServices = _ourServicesManager.GetById(Convert.ToInt32(id));
            if (ourServices == null)
            {
                return RedirectToAction("Home", "Error");
            }
            return View(ourServices);
        }
        [HttpPost]
        public IActionResult DeleteOurServices(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Home", "Error");
            }
            var ourServices = _ourServicesManager.GetById(id);
            if (ourServices == null)
            {
                return RedirectToAction("Home", "Error");
            }
            if (ModelState.IsValid)
            {
                _ourServicesManager.OurServicesDelete(ourServices);
            }
            return RedirectToAction(nameof(OurServices));
        }

        public IActionResult Fleet(int id)
        {
            var result = _fleetManager.GetList();
            return View(result);
        }
        [HttpGet]
        public IActionResult EditFleet(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Home", "Error");
            }
            var fleet = _fleetManager.GetById(Convert.ToInt32(id));
            if (fleet == null)
            {
                return RedirectToAction("Home", "Error");
            }
            return View(fleet);
        }
        [HttpPost]
        public IActionResult EditFleet(Fleet fleet)
        {
            if (ModelState.IsValid)
            {
                _fleetManager.FleetUpdate(fleet);
                return RedirectToAction(nameof(Fleet));
            }
            return View(fleet);
        }
        [HttpGet]
        public IActionResult AddFleet()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFleet(Fleet fleet)
        {
            if (ModelState.IsValid)
            {
                _fleetManager.FleetInsert(fleet);
                return RedirectToAction(nameof(Fleet));
            }
            return View(fleet);
        }
        [HttpGet]
        public IActionResult DeleteFleet(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Home", "Error");
            }
            var fleet = _fleetManager.GetById(Convert.ToInt32(id));
            if (fleet == null)
            {
                return RedirectToAction("Home", "Error");
            }
            return View(fleet);
        }
        [HttpPost]
        public IActionResult DeleteFleet(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Home", "Error");
            }
            var fleet = _fleetManager.GetById(id);
            if (fleet == null)
            {
                return RedirectToAction("Home", "Error");
            }
            if (ModelState.IsValid)
            {
                _fleetManager.FleetDelete(fleet);
            }
            return RedirectToAction(nameof(Fleet));
        }

        public IActionResult Gallery(int id)
        {
            var result = _galleryManager.GetList();
            return View(result);
        }
        [HttpGet]
        public IActionResult EditGallery(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Home", "Error");
            }
            var gallery = _galleryManager.GetById(Convert.ToInt32(id));
            if (gallery == null)
            {
                return RedirectToAction("Home", "Error");
            }
            return View(gallery);
        }
        [HttpPost]
        public IActionResult EditGallery(Gallery gallery)
        {
            if (ModelState.IsValid)
            {
                _galleryManager.GalleryUpdate(gallery);
                return RedirectToAction(nameof(Gallery));
            }
            return View(gallery);
        }
        [HttpGet]
        public IActionResult AddGallery()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddGallery(Gallery gallery)
        {
            if (ModelState.IsValid)
            {
                _galleryManager.GalleryInsert(gallery);
                return RedirectToAction(nameof(Gallery));
            }
            return View(gallery);
        }
        [HttpGet]
        public IActionResult DeleteGallery(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Home", "Error");
            }
            var gallery = _galleryManager.GetById(Convert.ToInt32(id));
            if (gallery == null)
            {
                return RedirectToAction("Home", "Error");
            }
            return View(gallery);
        }
        [HttpPost]
        public IActionResult DeleteGallery(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Home", "Error");
            }
            var gallery = _galleryManager.GetById(id);
            if (gallery == null)
            {
                return RedirectToAction("Home", "Error");
            }
            if (ModelState.IsValid)
            {
                _galleryManager.GalleryDelete(gallery);
            }
            return RedirectToAction(nameof(Gallery));
        }

        public IActionResult Contact(int id)
        {
            var result = _contactManager.GetList();
            return View(result);
        }
        [HttpGet]
        public IActionResult EditContact(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Home", "Error");
            }
            var contact = _contactManager.GetById(Convert.ToInt32(id));
            if (contact == null)
            {
                return RedirectToAction("Home", "Error");
            }
            return View(contact);
        }
        [HttpPost]
        public IActionResult EditContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactManager.ContactUpdate(contact);
                return RedirectToAction(nameof(Contact));
            }
            return View(contact);
        }
    }
}

