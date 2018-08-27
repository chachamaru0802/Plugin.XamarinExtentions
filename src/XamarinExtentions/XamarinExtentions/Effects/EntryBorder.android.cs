using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Text;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using PlatformEffects = Plugin.XamarinExtentions.Effects.Droid;
using RoutingEffects = Plugin.XamarinExtentions.Effects;

[assembly: ExportEffect(typeof(PlatformEffects.EntryBorder), nameof(RoutingEffects.EntryBorder))]


namespace Plugin.XamarinExtentions.Effects.Droid
{
    public class EntryBorder : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control == null)
            {
                return;
            }

            var editText = Control as EditText;

            if (editText == null)
            {
                return;
            }

            var effect = (RoutingEffects.EntryBorder)Element.Effects.FirstOrDefault(x => x is RoutingEffects.EntryBorder);
            var lineColor = effect.LineColor;
                
            var shape = new ShapeDrawable();
            shape.Paint.Color = lineColor.ToAndroid();
            shape.Paint.SetStyle(Paint.Style.Stroke);
            editText.Background = shape;
        }

        protected override void OnDetached()
        {
        }
    }
}
