using AuthorizeVeAuthentication.Models;
using AuthorizeVeAuthentication.Models.IRepository.Kullanici;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AuthorizeVeAuthentication.Controllers
{
    public class LoginController : Controller
    {
        private readonly IKullaniciReadRepository _kullaniciReadRepository;
        public LoginController(IKullaniciReadRepository kullaniciReadRepository)
        {
            _kullaniciReadRepository= kullaniciReadRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string kullanici,string sifre)
        {
            var _kullanici = _kullaniciReadRepository.GetWhere(k => k.ad == kullanici);
            bool giris = false;
            foreach (var item in _kullanici)
            {
                if (item.ad == kullanici || item.email == kullanici && item.sifre == sifre)
                {
                    giris = true;
                }
                
            }
            if (giris)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,kullanici),
                    new Claim(ClaimTypes.Role,"Admin"),
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties();

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                return RedirectToAction("Index", "Home");
            }
                else
                return RedirectToAction("Index", "Login");

        }
    }
}
