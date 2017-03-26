using CustomerRelations.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CustomerRelations.Web.Localization
{
    public class CustomerRelationsResourceDisplayName : System.ComponentModel.DisplayNameAttribute, IModelAttribute
    {
        private string _resourceValue = string.Empty;
        //private bool _resourceValueRetrived;

        public CustomerRelationsResourceDisplayName(string resourceKey)
            : base(resourceKey)
        {
            ResourceKey = resourceKey;
        }

        public string ResourceKey { get; set; }

        public override string DisplayName
        {
            get
            {
                var langCode = ConfigurationManager.AppSettings["LangCode"].ToString();
                var cacheSession = (List<StringResource>) HttpContext.Current.Session["ResourceList"];
                _resourceValue = cacheSession.Where(x => x.cultureCode == langCode && x.resourceKey == this.ResourceKey).First().resourceValue;
                return _resourceValue;
            }
        }
        public string Name
        {
            get
            {
                 return "CustomerRelationsResourceDisplayName"; 
            }
        }
    }
}