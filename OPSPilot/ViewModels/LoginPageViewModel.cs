using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OPSPilot.ViewModels
{
    public class LoginPageViewModel:ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _loginCommand;
        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Login Page";
            _navigationService = navigationService;

        }
        public DelegateCommand LoginCommand => _loginCommand ?? (_loginCommand = new DelegateCommand(Login));

        private async void Login()
        {
            await _navigationService.NavigateAsync("HomePage");
        }
    }
}
