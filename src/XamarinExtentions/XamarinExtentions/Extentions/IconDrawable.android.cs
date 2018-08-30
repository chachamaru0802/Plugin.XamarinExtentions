using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Text;
using Android.Util;
using Plugin.XamarinExtentions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plugin.XamarinExtentions.Extentions
{
    public class IconDrawable : Drawable
    {
        public const Int32 ANDROID_ACTIONBAR_ICON_SIZE_DP = 24;


        Int32 _alpha = 255;

        Context _context;

        IIconFont _icon;

        TextPaint _paint;

        Int32 _size = -1;

        public override int Opacity => _alpha;

        public IconDrawable SizeDp(Int32 size) => SizePx(ConvertDpToPx(_context, size));

        private Int32 ConvertDpToPx(Context context, Single dp) => (Int32)TypedValue.ApplyDimension(ComplexUnitType.Dip, dp, context.Resources.DisplayMetrics);


        public IconDrawable(Context context, String iconKey)
        {
            //var icon = Iconize.FindIconForKey(iconKey);


            IIconFont icon = null;

            if (icon == null)
                throw new ArgumentException($"No icon with the key: {iconKey}");

            Init(context, icon);
        }

        public IconDrawable(Context context, IIconFont icon)
        {
            Init(context, icon);
        }

        void Init(Context context, IIconFont icon)
        {
            var module = IconFontInitializer.IconFontModules.FirstOrDefault(x => x.HasIcon(icon));

            if (module == null)
                throw new Java.Lang.IllegalStateException($"Unable to find the module associated with icon {icon.Key}, have you registered the module you are trying to use with Iconize.With(...) in your Application?");

            _context = context;
            _icon = icon;

            _paint = new TextPaint
            {
                AntiAlias = true,
                Color = Android.Graphics.Color.Black,
                TextAlign = Paint.Align.Left,
                UnderlineText = false
            };
            _paint.SetStyle(Paint.Style.Fill);
            _paint.SetTypeface(module.ToTypeface(context));
        }


        public IconDrawable SizePx(Int32 size)
        {
            _size = size - 10;
            SetBounds(0, 0, size, size);
            InvalidateSelf();
            return this;
        }

        public IconDrawable Color(Int32 color)
        {
            _paint.Color = new Color(color);
            InvalidateSelf();
            return this;
        }

        public override void Draw(Canvas canvas)
        {
            var bounds = Bounds;
            var height = bounds.Height();
            _paint.TextSize = _size ;
            var textBounds = new Rect();
            var textValue = _icon.Character.ToString();
            _paint.GetTextBounds(textValue, 0, 1, textBounds);
            var textHeight = textBounds.Height();
            var textBottom = bounds.Top + ((height - textHeight) / 2f) + textHeight - textBounds.Bottom;
            canvas.DrawText(textValue, bounds.ExactCenterX(), textBottom, _paint);
        }

        public override void SetAlpha(int alpha)
        {
            _alpha = alpha;
            _paint.Alpha = alpha;
        }

        public override void SetColorFilter(ColorFilter colorFilter)
        {
            _paint.SetColorFilter(colorFilter);
        }
    }
}
