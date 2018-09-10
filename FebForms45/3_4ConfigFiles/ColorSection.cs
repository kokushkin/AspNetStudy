using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ConfigFiles
{
    public class ColorSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(ColorCollection))]
        public ColorCollection Colors
        {
            get { return (ColorCollection)base[""]; }
        }

        [ConfigurationProperty("default")]
        public string Default
        {
            get { return (string)base["default"]; }
            set { base["default"] = value; }
        }
    }
}