using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ConfigFiles
{
    public class UserAndPlaceSectiongroup : ConfigurationSectionGroup
    {
        [ConfigurationProperty("newUserDefaults", IsRequired = true)]
        public NewUserDefaultsSection NewUserDefaults
        {
            get { return (NewUserDefaultsSection)Sections["newUserDefaults"]; }
        }

        [ConfigurationProperty("colors", IsRequired = true)]
        public ColorSection Colors
        {
            get { return (ColorSection)Sections["colors"]; }
        }
    }
}