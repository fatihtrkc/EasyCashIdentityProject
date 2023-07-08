using DataTransferObjectLayer.Dtos.AppUserDtos;
using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace EasyCashIdentityProject.UILayer.Controllers
{
    public class SignUpController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        public SignUpController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserAddDto appUserAddDto)
        {
            if (ModelState.IsValid)
            {
                Random random = new();
                int confirmCode = random.Next(100_000, 1_000_000);

                AppUser appUser = new AppUser()
                {
                    UserName = appUserAddDto.UserName,
                    Name = appUserAddDto.Name,
                    Surname = appUserAddDto.Surname,
                    Email = appUserAddDto.Email,
                    ConfirmCode = confirmCode
                };

                var result = await userManager.CreateAsync(appUser, appUserAddDto.Password);

                if (result.Succeeded)
                {
                    MimeMessage mimeMessage = new();
                    MailboxAddress mailboxAddressFrom = new MailboxAddress("Easy Cash Identity", "");
                    MailboxAddress mailboxAddressTo = new MailboxAddress("User", appUser.Email);

                    mimeMessage.From.Add(mailboxAddressFrom);
                    mimeMessage.To.Add(mailboxAddressTo);

                    var bodyBuilder = new BodyBuilder();
                    bodyBuilder.TextBody = "Easy Cash Identity Sign Up process confirm code :  " + confirmCode;
                    mimeMessage.Body = bodyBuilder.ToMessageBody();
                    mimeMessage.Subject = "Easy Cash Identity Sign Up Confirm Code";

                    SmtpClient client = new();
                    client.Connect("", 587, false);
                    client.Authenticate("", "");
                    client.Send(mimeMessage);
                    client.Disconnect(true);

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