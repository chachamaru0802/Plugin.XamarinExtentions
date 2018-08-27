using Plugin.XamarinExtentions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plugin.XamarinExtentions.Fonts
{
    public interface IIconFontModule
    {
        ICollection<IIconFont> Characters { get; }

        String FontFamily { get; }

        String FontName { get; }

        String FontPath { get; }

        ICollection<String> Keys { get; }

        IIconFont GetIcon(String key);

        Boolean HasIcon(IIconFont icon);
    }

    public abstract class IconFontModule : IIconFontModule
    {
        public ICollection<IIconFont> Characters => _icons.Values;

        public string FontFamily { get; }

        public string FontName { get; }

        public string FontPath { get; }

        public ICollection<string> Keys => _icons.Keys;

        Dictionary<String, IIconFont> _icons { get; } = new Dictionary<String, IIconFont>();

        protected IconFontModule(String fontFamily, String fontName, String fontPath, IEnumerable<IIconFont> icons)
        {
            FontFamily = fontFamily;
            FontName = fontName;
            FontPath = fontPath;

            _icons = icons.ToDictionary(x => x.Key, x => x);
           
        }

        public IIconFont GetIcon(string key) => _icons.ContainsKey(key) ? _icons[key] : null;

        public bool HasIcon(IIconFont icon) => _icons.ContainsValue(icon);
    }
}
