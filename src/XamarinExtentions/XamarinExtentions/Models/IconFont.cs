using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.XamarinExtentions.Models
{
    public interface IIconFont
    {
        string Key { get; }

        Char Character { get; }
    }

    public class IconFont : IIconFont
    {
        public string Key { get; }

        public Char Character { get; }

        public IconFont(string key, char character)
        {
            Key = key;
            Character = character;
        }
    }
}
