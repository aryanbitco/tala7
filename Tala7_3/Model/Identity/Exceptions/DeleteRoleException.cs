using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tala7_3.Abstracts;
using Tala7_3.Base_Exception;

namespace DRR.Domain.Identity.Exceptions
{
    public sealed class DeleteRoleException : BusinessException
    {
        public DeleteRoleException(string message)
            : base(ExceptionCodes.Roll.DeleteRollError)
        {
            Message = message;
        }

        public override string Message { get; }
    }
}
