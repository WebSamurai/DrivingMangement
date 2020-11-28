using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriveManagement.Controllers.Common
{
    public class SelectItem<T>
    {
        public T Value { get; set; }
        public string Label { get; set; }
    }
}
