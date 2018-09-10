using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ConfigFiles
{
    public class Color : ConfigurationElement
    {
        [ConfigurationProperty("code", IsRequired = true)]
        public string Code
        {
            get { return (string)this["code"]; }
            set { this["code"] = value; }
        }

        [ConfigurationProperty("value", IsRequired = true)]
        public string Value
        {
            get { return (string)this["value"]; }
            set { this["value"] = value; }
        }

        [ConfigurationProperty("name", IsRequired = true)]
        public String Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }
    }
}