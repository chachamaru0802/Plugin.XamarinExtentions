using Android.Content;
using Android.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.XamarinExtentions.Extentions
{
    public static class PlatformExtentions
    {
        private static readonly Dictionary<Type, Typeface> _fontCache = new Dictionary<Type, Typeface>();


        public static Typeface ToTypeface(this IIconFontModule module, Context context)
        {
            var moduleType = module.GetType();
            if (!_fontCache.ContainsKey(moduleType))
            {
                _fontCache.Add(moduleType, Typeface.CreateFromAsset(context.Assets, module.FontPath));
            }
            return _fontCache[moduleType];
        }
    }
}
