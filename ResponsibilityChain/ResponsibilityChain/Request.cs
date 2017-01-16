using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsibilityChain
{
    public class Request
    {
        public RequestType RequestType { get; set; }
        public string RequestContent { get; set; }
        public int Quantity { get; set; }
    }
}
