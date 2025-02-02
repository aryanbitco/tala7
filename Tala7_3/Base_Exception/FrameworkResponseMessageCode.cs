using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tala7_3.Abstracts;

namespace Tala7_3.Base_Exception
{
    public sealed class FrameworkResponseMessageCode : ResponseMessageCode
    {
        public FrameworkResponseMessageCode(CodeAndMessage codeAndMessage) : base("FrameworkException", codeAndMessage.Code, codeAndMessage.Message)
        {
        }

        public static implicit operator FrameworkResponseMessageCode(CodeAndMessage codeAndMessage)
        {
            return new FrameworkResponseMessageCode(codeAndMessage);
        }
    }
}
