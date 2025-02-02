using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tala7_3.Abstracts;

namespace Tala7_3.Base_Exception
{
    public sealed class DomainExceptionMessageCode : ExceptionMessageCode
    {
        public DomainExceptionMessageCode(int code) : base("DomainException", code)
        {
        }

        public static implicit operator DomainExceptionMessageCode(int first)
        {
            return new DomainExceptionMessageCode(first);
        }
    }
}
