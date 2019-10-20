﻿using Prism;
using Prism.Ioc;
using _Countries.Prism.ViewModels;
using _Countries.Prism.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Countries.prism.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace _Countries.Prism
{
    public partial class App
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