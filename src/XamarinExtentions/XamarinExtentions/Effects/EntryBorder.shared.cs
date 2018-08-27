using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Plugin.XamarinExtentions.Effects
{
    public class EntryBorder : RoutingEffect
    {
        public Color LineColor { get; set; } = Color.Black;

        public EntryBorder() : base(EffectIds.EntryBorder)
        {
        }
    }
}
