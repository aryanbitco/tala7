using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tala7_3.Abstracts;

namespace Tala7_3.Base_Exception
{
    public sealed class FrameworkExceptionMessageCode : ExceptionMessageCode
    {
        public FrameworkExceptionMessageCode(int code) : base("FrameworkException", code)
        {
        }

        public static implicit operator FrameworkExceptionMessageCode(int first)
        {
            return new FrameworkExceptionMessageCode(first);
        }
    }
}
