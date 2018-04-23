using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace _4_5_MyConfigSection
{
    public class OrderService : ConfigurationSection
    {
        [ConfigurationProperty("available",
            IsRequired = false, DefaultValue = true)]
        public bool Available
        {
            get { return (bool)base["available"]; }
            set { base["available"] = value; }
        }

        [ConfigurationProperty("pollTimeout",
            IsRequired = true)]
        public TimeSpan PollTimeout
        {
            get { return (TimeSpan)base["pollTimeout"]; }
            set { base["pollTimeout"] = value; }
        }

        [ConfigurationProperty("location",
            IsRequired = true)]
        public string Location
        {
            get { return (string)base["location"]; }
            set { base["location"] = value; }
        }
    }
}