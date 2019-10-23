using Prism.Ioc;
using Countries.Prism.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Countries.prism.Services;
using Prism;
using MyLeasing.Common.Services;
using _Countries.Prism.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace _Countries.Prism
{
    

    public partial class App
    {
        
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/CountriesPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<CountriesPage, CountriesPageViewModel>();
        }
    }
}
