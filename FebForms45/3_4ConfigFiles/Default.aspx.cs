using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConfigFiles
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //public IEnumerable<string> GetConfig()
        //{
        //    foreach (string key in WebConfigurationManager.AppSettings)
        //    {
        //        yield return string.Format("{0} {1}", key,
        //            WebConfigurationManager.AppSettings[key]);
        //    }
        //}

        //public IEnumerable<string> GetConfig()
        //{
        //    object config = WebConfigurationManager
        //        .GetWebApplicationSection("system.web/compilation");
        //    CompilationSection section = config as CompilationSection;

        //    if (section != null)
        //    {
        //        yield return string.Format("debug = {0}<br>targetFramework = {1}<br>batch = {2}",
        //            section.Debug, section.TargetFramework, section.Batch);
        //    }
        //    else
        //    {
        //        yield return string.Format("Неправильный тип конфигурации: {0}",
        //            config.GetType());
        //    }
        //}


        //public IEnumerable<string> GetConfig()
        //{
        //    Configuration config
        //        = WebConfigurationManager.OpenWebConfiguration(Request.Path);

        //    SystemWebSectionGroup group =
        //        config.SectionGroups["system.web"] as SystemWebSectionGroup;

        //    CompilationSection compileSection = group.Compilation;

        //    yield return string.Format("debug = {0}<br>targetFramework = {1}<br>batch = {2}",
        //            compileSection.Debug,
        //            compileSection.TargetFramework,
        //            compileSection.Batch);
        //}

        //public IEnumerable<string> GetConfig()
        //{
        //    NewUserDefaultsSection defaults
        //        = (NewUserDefaultsSection)WebConfigurationManager
        //              .GetSection("newUserDefaults");

        //    yield return string.Format("Значения: {0}, {1}, {2}, {3}",
        //        defaults.City, defaults.Country, defaults.Language, defaults.Region);
        //}

        public IEnumerable<string> GetConfig()
        {
            Configuration config
                = WebConfigurationManager.OpenWebConfiguration(Request.Path);

            ColorSection section = config.Sections["colors"] as ColorSection;
            Color defaultColor = section.Colors[section.Default];
            yield return string.Format(
                @"Цвет по умолчанию - <span style=""color:white;background:{0}"">{1}</span><br><br>",
                defaultColor.Value, defaultColor.Name);

            foreach (Color color in section.Colors)
                yield return string.Format(
                @"Цвет - <span style=""color:white;background:{0}"">{1}</span><br><br>",
                color.Value, color.Name);
        }
    }
}