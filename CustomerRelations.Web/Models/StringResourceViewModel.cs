using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerRelations.Web.Models
{
    public class StringResourceViewModel
    {
        public string cultureCode { get; set; }
        public string resourceKey { get; set; }
        public string resourceValue { get; set; }
    }
}