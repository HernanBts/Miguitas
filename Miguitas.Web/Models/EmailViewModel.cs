using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miguitas.Web.Models
{
    public class EmailViewModel
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
