using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PlatformEffects = Plugin.XamarinExtentions.Effects.iOS;
using RoutingEffects = Plugin.XamarinExtentions.Effects;

[assembly: ExportEffect(typeof(PlatformEffects.EntryBorder), nameof(RoutingEffects.EntryBorder))]


namespace Plugin.XamarinExtentions.Effects.iOS
{
    public class EntryBorder : PlatformEffect
    {
        protected override void OnAttached()
        {
        }

        protected override void OnDetached()
        {
        }
    }
}
