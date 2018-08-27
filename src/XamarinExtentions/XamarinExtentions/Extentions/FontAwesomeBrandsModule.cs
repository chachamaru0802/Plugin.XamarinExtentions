using System;
using System.Collections.Generic;
using System.Text;
using Plugin.XamarinExtentions.Models;

namespace Plugin.XamarinExtentions.Extentions
{
    public class FontAwesomeBrandsModule : IconFontModule
    {
        public FontAwesomeBrandsModule()
            : base("Font Awesome 5 Brands", "FontAwesome5BrandsRegular", "FontAwesomeBrands.otf", FontAwesomeCollection.BrandIcons)
        {
        }
    }
}
