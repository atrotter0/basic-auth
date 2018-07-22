using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using BasicAuth.Models;
using System.Threading.Tasks;
using BasicAuth.ViewModels;

namespace BasicAuth.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        [HttpGet("/account")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/account/register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("/account/register")]
        public async Task<IActionResult> Register (RegisterViewModel model)
        {
            var user = new ApplicationUser { UserName = model.Email };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}