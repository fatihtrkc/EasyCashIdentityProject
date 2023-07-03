using DataTransferObjectLayer.Dtos.AppUserDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.UILayer.Controllers
{
    public class SignUpController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public SignUpController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserSignUpDto appUserSignUpDto)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = appUserSignUpDto.UserName,
                    Name = appUserSignUpDto.Name,
                    Surname = appUserSignUpDto.Surname,
                    Email = appUserSignUpDto.Email
                };

                var result = await _userManager.CreateAsync(appUser, appUserSignUpDto.Password);

                if (result.Succeeded) 
                {
                    return RedirectToAction("Index", "EmailConfirm");
                }
                else 
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}

// pasword 6 karakter
// 1 küçük harf
// 1 büyük harf
// 1 sembol
// 1 sayı
