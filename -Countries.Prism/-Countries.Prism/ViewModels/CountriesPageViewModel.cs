using _Countries.Prism;
using Countries.Prism.ViewModels;
using Countries.prism.Services;
using Countries.Prism.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Countries.Prism.ViewModels
{
    public class CountriesPageViewModel : ViewModelBase
    {

        private readonly IApiService _apiService;
        private readonly INavigationService _navigationService;
        private ObservableCollection<pais> _countrylist;
        public CountriesPageViewModel(INavigationService navigationService,
        IApiService apiService) : base(navigationService)

        {
            Title = "Countries";
            _apiService = apiService;
            _navigationService = navigationService;
            Api();
        }

        public ObservableCollection<pais> ContryList
        {
            get => _countrylist;
            set => SetProperty(ref _countrylist, value);
        }

        private async void Api()
        {
            var url = "https://restcountries.eu/rest/v2/all";

            var response = await _apiService.ApiCountryAsync<pais>(url);

            if (!response.IsSuccess)
            {

                await App.Current.MainPage.DisplayAlert(
                    "Error",
                    "Error",
                    "Accept");
                return;
            }
            var countrieslist = (List<pais>)response.Result;
            ContryList = new ObservableCollection<pais>(countrieslist.Select(t => new pais
            {
                Name = t.Name,
                TopLevelDomain = t.TopLevelDomain,
                Alpha2Code = t.Alpha2Code,
                Alpha3Code = t.Alpha3Code,
                CallingCodes = t.CallingCodes,
                Capital = t.Capital,
                AltSpellings = t.AltSpellings,
                Region = t.Region,
                Subregion = t.Subregion,
                Population = t.Population,
               Latlng = t.Latlng,
                Demonym = t.Demonym,
                Area = t.Area,
                Gini = t.Gini,
                Timezones = t.Timezones,
                Borders = t.Borders,
                NativeName = t.NativeName,
                NumericCode = t.NumericCode,
                Flag = t.Flag,
                Cioc = t.Cioc

            }).ToList());
        }
    }
}