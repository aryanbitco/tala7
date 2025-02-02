using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tala7_3.Abstracts;
using Tala7_3.Base_Exception;

namespace Tala7_3.Model.Identity.Exception
{
    public sealed class IdentitySignOutException : BusinessException
    {
        public IdentitySignOutException()
            : base(ExceptionCodes.Identity.ClientHaveNoToken)
        {
        }

        public override string EnglishMessage => "You Are Not Sign In !";
        public override string PersianMessage  => "شما به سایت وارد نشده اید !";
    }

    public sealed class IdentityUserIsDefinedException : BusinessException
    {
        public IdentityUserIsDefinedException()
            : base(ExceptionCodes.Identity.UserIsDefined)
        {
        }

        public override string EnglishMessage  => "user name is defined before !";
        public override string PersianMessage => "نام کاربری تکراری می باشد !";
    }
}
