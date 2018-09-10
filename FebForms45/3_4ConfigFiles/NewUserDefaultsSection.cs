using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ConfigFiles
{
    public class NewUserDefaultsSection : ConfigurationSection
    {
        [CallbackValidator(CallbackMethodName = "ValidateCity",
            Type = typeof(NewUserDefaultsSection))]
        [ConfigurationProperty("city", IsRequired = true)]
        public string City
        {
            get { return (string)this["city"]; }
            set { this["city"] = value; }
        }

        public static void ValidateCity(object candidateValue)
        {
            string value = (string)candidateValue;
            if (value.ToLower() == "париж")
            {
                throw new Exception("Любой город, кроме Парижа");
            }
        }

        [ConfigurationProperty("country", DefaultValue = "Россия")]
        public string Country
        {
            get { return (string)this["country"]; }
            set { this["country"] = value; }
        }

        [ConfigurationProperty("language")]
        public string Language
        {
            get { return (string)this["language"]; }
            set { this["language"] = value; }
        }

        [ConfigurationProperty("regionCode", DefaultValue = "1")]
        [IntegerValidator(MaxValue = 99, MinValue = 1)]
        public int Region
        {
            get { return (int)this["regionCode"]; }
            set { this["regionCode"] = value; }
        }
    }
}