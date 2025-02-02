using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Tala7_3.Data;
using Tala7_3.Model;
using Tala7_3.Model.Profile;
using Tala7_3.View;
using System.Security.Cryptography;
using System.Text;
using Tala7_3.Abstracts;

using Tala7_3.Model.Identity.Exception;
using Microsoft.AspNetCore.Identity;
using Swashbuckle.AspNetCore.Annotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Tala7_3.Controllers

{

    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly SignInManager<Model.ApplicationUser> _signInManager;
        private readonly UserManager<Model.ApplicationUser> _userManager;
        private readonly DataContext _context;//اینجکشن به دیتا بیس

        public ApplicationUserController(DataContext context, UserManager<Model.ApplicationUser> userManager)//کانستاراکتور
        {
            _context = context;
            //_signInManager = signInManager;
            _userManager = userManager;
        }




        [SwaggerOperation(Summary = "ایجاد یک کاربر")]
        [AllowAnonymous]
        [HttpPost("UserSignUp")]  //Create user
        public async Task<ActionResult<ApplicationUser>> UserSignUp(ApplicationUserDto applicationUserDto)
        {
            //          "id": "string",
            //"userName": "string",
            //"normalizedUserName": "string",
            //"email": "string",
            //"normalizedEmail": "string",
            //"emailConfirmed": true,
            //"passwordHash": "string",
            //"securityStamp": "string",
            //"concurrencyStamp": "string",
            //"phoneNumber": "string",
            //"phoneNumberConfirmed": true,
            //"twoFactorEnabled": true,
            //"lockoutEnd": "2025-01-22T10:41:02.147Z",
            //"lockoutEnabled": true,
            //"accessFailedCount": 0,
            //"fullname": "string"
            if (_context.ApplicationUsers.Where(x => x.UserName == applicationUserDto.UserName).Count() > 0)
            {
                //throw new IdentityUserIsDefinedException();
                throw new Exception("نام کاربری تکراری می باشد");

            }
            if (applicationUserDto.UserName.Length != 11 )
                throw new Exception("تلفن وارد شده اشتباه است");

            var user = new ApplicationUser
            {
                UserName = applicationUserDto.UserName,
                //PhoneNumber = applicationUserDto.PhoneNumber.ConvertToValidMobile(),
                //Fullname = applicationUserDto.Fullname
            };

            //ApplicationUser user = new ApplicationUser();
            //user.UserName = applicationUserDto.UserName;
            //user.PasswordHash = Hash.ComputeHash(applicationUserDto.Password, new SHA256CryptoServiceProvider());
            //user.Fullname = "";


            var userCreate = await _userManager.CreateAsync(user, applicationUserDto.Password); //افزودن ابجکت ارسالی توسط دی بی ست در دیتا بیس
            if (userCreate.Succeeded)
            {
                return Ok();
            }

            else
            {
                {
                    throw new Exception("کاربر ساخته نشد");
                }
            }










        }
    }
}
