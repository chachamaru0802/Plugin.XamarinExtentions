using System;
using System.Collections.Generic;
using System.Text;
using Plugin.XamarinExtentions.Fonts;

namespace Plugin.XamarinExtentions
{
    public static class IconFontInitializer
    {
        public static IReadOnlyCollection<IIconFontModule> IconFontModules { get; } 

        public static void Init()
        {
            var moduleList = new List<IIconFontModule>();

            moduleList.Add(new FontAwesomeBrandsModule());
            moduleList.Add(new FontAwesomeRegularModule());
            moduleList.Add(new FontAwesomeSolidModule());

        }
    }
}
