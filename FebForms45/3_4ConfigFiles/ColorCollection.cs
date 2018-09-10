using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ConfigFiles
{
    public class ColorCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new Color();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((Color)element).Code;
        }

        public new Color this[string key]
        {
            get
            {
                return (Color)BaseGet(key);
            }
        }
    }
}