using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace D3DotNetAPI.Exceptions
{
    public class ErrorInfo
    {
        public Exception OriginalException { get; set; }
        public ErrorDetail ErrorDetail { get; set; }
        public string RequestUrl { get; set; }
    }
}
