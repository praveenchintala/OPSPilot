using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OPSPilot.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _workPermitsCommand;
        public HomePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            Banner = "Operational Safety Management";
        }

        private string _banner;
        public string Banner
        {
            get { return _banner; }
            set { SetProperty(ref _banner, value); }
        }

        public DelegateCommand WorkPermitsCommand => _workPermitsCommand ?? (_workPermitsCommand = new DelegateCommand(GoToWorkPermits));

        private async void GoToWorkPermits()
        {
            await _navigationService.NavigateAsync("SearchPermitsPage");
        }
    }
}
