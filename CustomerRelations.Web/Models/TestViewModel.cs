using CustomerRelations.Web.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerRelations.Web.Models
{
    public class TestViewModel
    {
        [CustomerRelationsResourceDisplayName("test")]
        public string Test { get; set; }
    }
}