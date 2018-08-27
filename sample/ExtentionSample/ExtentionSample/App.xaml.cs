using Prism;
using Prism.Ioc;
using ExtentionSample.ViewModels;
using ExtentionSample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ExtentionSample
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            Plugin.XamarinExtentions.IconFontInitializer.Init();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
        }
    }
}
