using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Shared = Plugin.XamarinExtentions.Controls;
using Platform = Plugin.XamarinExtentions.Controls.iOS;
using Xamarin.Forms.Platform.iOS;
using Plugin.XamarinExtentions.Extentions;
using UIKit;

[assembly: ExportRenderer(typeof(Shared.IconEntry), typeof(Platform.IconEntry))]

namespace Plugin.XamarinExtentions.Controls.iOS
{
    public class IconEntry : EntryRenderer
    {
        Shared.IconEntry Entry => Element as Shared.IconEntry;

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                return;
            }

            UpdateIconFont();
        }

        void UpdateIconFont()
        {
            if (string.IsNullOrWhiteSpace(Entry.IconFont))
            {
                return;
            }

            var icon = IconFontInitializer.FindIconForKey(Entry.IconFont);

            var image = icon.ToUIImage((nfloat)(-1.0));

            var imageView =new UIImageView();
            imageView.Image = image;

            Control.LeftView = imageView;
            Control.LeftViewMode = UITextFieldViewMode.Always;
        }
    }
}
