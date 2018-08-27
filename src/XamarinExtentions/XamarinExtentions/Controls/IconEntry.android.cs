using Android.Content;
using Plugin.XamarinExtentions.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Shared = Plugin.XamarinExtentions.Controls;
using Platform = Plugin.XamarinExtentions.Controls.Droid;
using Plugin.XamarinExtentions.Extentions;

[assembly:ExportRenderer(typeof(Shared.IconEntry),typeof(Platform.IconEntry))]

namespace Plugin.XamarinExtentions.Controls.Droid
{
    public class IconEntry : EntryRenderer
    {
        Shared.IconEntry Entry => Element as Shared.IconEntry;

        public IconEntry(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control ==null)
            {
                return;
            }

            UpdateIconFont();
        }

        void UpdateIconFont()
        {
            if(string.IsNullOrWhiteSpace(Entry.IconFont))
            {
                return;
            }

            var icon = IconFontInitializer.FindIconForKey(Entry.IconFont);

            var drawable = new IconDrawable(Context, icon).Color(Entry.IconColor.ToAndroid())
                                                           .SizeDp((Int32)Entry.FontSize);

            Control.SetCompoundDrawablesWithIntrinsicBounds(drawable, null, null, null);
        }
    }
}
