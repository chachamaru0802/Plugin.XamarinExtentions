using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plugin.XamarinExtentions.Extentions;
using Plugin.XamarinExtentions.Models;

namespace Plugin.XamarinExtentions
{
    public static class IconFontInitializer
    {
        public static IReadOnlyCollection<IIconFontModule> IconFontModules { get; private set; }

        public static void Init()
        {
            var moduleList = new List<IIconFontModule>();

            moduleList.Add(new FontAwesomeBrandsModule());
            moduleList.Add(new FontAwesomeRegularModule());
            moduleList.Add(new FontAwesomeSolidModule());

            IconFontModules = moduleList;
        }

        public static IIconFontModule FindModule(IIconFont icon)
        {
            return IconFontModules.FirstOrDefault(x => x.HasIcon(icon));
        }

        public static IIconFont FindIconForKey(String iconKey)
        {
            if (String.IsNullOrWhiteSpace(iconKey))
                return null;

            return IconFontModules.FirstOrDefault(x => x.Keys.Contains(iconKey))?.GetIcon(iconKey);
        }

        public static IIconFontModule FindModuleOf(IIconFont icon) => IconFontModules.FirstOrDefault(x => x.HasIcon(icon));
    }
}
