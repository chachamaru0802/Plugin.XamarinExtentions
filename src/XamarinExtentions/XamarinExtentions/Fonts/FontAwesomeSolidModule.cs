using System;
using System.Collections.Generic;
using System.Text;
using Plugin.XamarinExtentions.Models;

namespace Plugin.XamarinExtentions.Fonts
{
    public class FontAwesomeSolidModule : IconFontModule
    {
        public FontAwesomeSolidModule()
            : base("Font Awesome 5 Free Solid", "FontAwesome5FreeSolid", "FontAwesomeSolid.otf", FontAwesomeCollection.SolidIcons)
        {
        }
    }
}
