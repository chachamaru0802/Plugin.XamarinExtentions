using System;
using System.Collections.Generic;
using System.Text;
using Plugin.XamarinExtentions.Models;

namespace Plugin.XamarinExtentions.Extentions
{
    public class FontAwesomeRegularModule : IconFontModule
    {
        public FontAwesomeRegularModule() 
            : base("Font Awesome 5 Free Regular", "FontAwesome5FreeRegular", "FontAwesomeRegular.otf", FontAwesomeCollection.RegularIcons)
        {
        }
    }
}
