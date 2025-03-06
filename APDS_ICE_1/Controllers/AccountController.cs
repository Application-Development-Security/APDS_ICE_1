using APDS_ICE_1.Entities;
using APDS_ICE_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace APDS_ICE_1.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext appDbContext)
        {
           _context = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]  
        public IActionResult Registration(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                Accounts accounts = new Accounts();
                accounts.Email = model.Email;
                accounts.FirstName = model.FirstName;
                accounts.LastName = model.LastName;
                accounts.Password = model.Password;
                accounts.UserName = model.UserName;

                try
                {
                    _context.Accounts.Add(accounts);
                    _context.SaveChanges(); // Save changes to the database

                    ModelState.Clear();
                    ViewBag.Message = $"{accounts.FirstName} {accounts.LastName} registerd successfully.Plese login";

                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Please enter unique Email or Password");
                    return View(model);
                }
                return View();
            }

            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid) 
            {
                var user = _context.Accounts.Where(x => x.UserName == model.UserNameOrdEmail || x.Email== model.UserNameOrdEmail && x.Password == model.Password).FirstOrDefault();
                if (user != null) 
                {
                    //  sucess
                }
                else
                {
                    ModelState.AddModelError("", "Username/Email or password is not correct");
                }
                 
            }
            return View(model);

        }
        public IActionResult SecurePage()
        {
            return View();
        }
    }
}
