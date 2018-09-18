using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Plugin.XamarinExtentions.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupHeader : ContentView
    {
        #region BindableProperty

        public static readonly BindableProperty HeaderTitleProperty =
            BindableProperty.Create(nameof(HeaderTitle), typeof(string), typeof(string), null, propertyChanged: (b, s, v) => { ((GroupHeader)b).HeaderTitle = (string)v; },defaultBindingMode:BindingMode.TwoWay);

        #endregion

        #region プロパティ

        #region HeaderTitle

        /// <summary>
        /// Header Title
        /// </summary>
        public string HeaderTitle
        {
            get => (string)GetValue(HeaderTitleProperty);
            set
            {
                SetValue(HeaderTitleProperty, value);
                HeaderLabel.Text = (string)GetValue(HeaderTitleProperty);
            }
        }

        #endregion

        #region FontSize

        /// <summary>
        /// FontSize
        /// </summary>
        public double FontSize
        {
            get => HeaderLabel.FontSize;
            set => HeaderLabel.FontSize = value;
        }

        #endregion

        #region TextColor

        
        /// <summary>
        /// TextColor
        /// </summary>
        public Color TextColor
        {
            get => HeaderLabel.TextColor;
            set => HeaderLabel.TextColor = value;
        }

        #endregion

        #region BorderColor

        /// <summary>
        /// BorderColor
        /// </summary>
        public Color BorderColor
        {
            get => HeaderBorder.BackgroundColor;
            set
            {
                HeaderBorder.BackgroundColor = value;
                FooterBorder.BackgroundColor = value;
            }
        }

        #endregion

        #endregion

        #region コンストラクタ
       

        public GroupHeader()
        {
            InitializeComponent();
        }

        #endregion
    }
}