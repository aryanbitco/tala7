using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tala7_3.Abstracts;
using Tala7_3.Base_Exception;

namespace Tala7_3.Model.Identity.Exception
{
    public sealed class IdentityUsernameOrPasswordException : BusinessException
    {
        public IdentityUsernameOrPasswordException()
            : base(ExceptionCodes.Identity.UsernameOrPasswordIncorrect)
        {
        }

        public override string EnglishMessage => "Username Or Password Is Incorrect !";
        public override string? PersianMessage => "نام کاربری یا کلمه عبور اشتباه است !";
    }
}
