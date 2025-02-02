using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tala7_3.Enums;

namespace Tala7_3.Model.Abstracts
{
    public sealed class StructureMessage
    {
        public ContentLanguage MessageLanguage { get; set; }
        public string Message { get; set; }
    }
}
