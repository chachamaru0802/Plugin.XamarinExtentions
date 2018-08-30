using CoreGraphics;
using CoreText;
using Foundation;
using Plugin.XamarinExtentions.Models;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace Plugin.XamarinExtentions.Extentions
{
   public static class PlatformExtentions
    {
        public static UIImage ToUIImage(this IIconFont icon, nfloat size)
        {
            var attributedString = new NSAttributedString($"{icon.Character}", new CTStringAttributes
            {
                Font = new CTFont(IconFontInitializer.FindModule (icon).FontName, size),
                ForegroundColorFromContext = true
            });

            var boundSize = attributedString.GetBoundingRect(new CGSize(10000f, 10000f), NSStringDrawingOptions.UsesLineFragmentOrigin, null).Size;

            UIGraphics.BeginImageContextWithOptions(boundSize, false, 0f);
            attributedString.DrawString(new CGRect(0f, 0f, boundSize.Width, boundSize.Height));
            using (var image = UIGraphics.GetImageFromCurrentImageContext())
            {
                UIGraphics.EndImageContext();

                return image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
            }
        }
    }
}
