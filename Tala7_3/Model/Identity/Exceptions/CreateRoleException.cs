using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tala7_3.Abstracts;
using Tala7_3.Base_Exception;


namespace Tala7_3.Model.Identity.Exception
{
    public sealed class CreateRoleException : BusinessException
    {
        public CreateRoleException(string message)
            : base(ExceptionCodes.Roll.CreateRollError)
        {
            Message = message;
        }

        public override string Message { get; }
    }
}
