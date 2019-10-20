using Countries.prism.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace -Countries.Prism.ViewModels
{
	public class CountriesPageViewModel : ViewModelBase
{

    private readonly IApiService _apiService;
    public CountriesPageViewModel(INavigationService navigationService,
        IApiService apiService) : base(navigationService) 

    {
        Title = "Countries";
        _apiService = apiService;
    }

}
}
