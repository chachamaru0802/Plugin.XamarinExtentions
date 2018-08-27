using Plugin.XamarinExtentions.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.XamarinExtentions.Extentions
{
    public static class CollectionExtentions
    {
        public static void Add(this IList<IIconFont> list, String key, Char character) => list.Add(new IconFont(key, character));

    }
}
