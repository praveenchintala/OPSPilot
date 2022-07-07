using OPSPilot.Models;
using OPSPilot.Services;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace OPSPilot.ViewModels
{
    public class SearchPermitsPageViewModel:ViewModelBase
    {
        private readonly IWorkpermitsService _workpermitsService;
        private DelegateCommand<string> _searchCommand;
        public SearchPermitsPageViewModel(INavigationService navigationService,IWorkpermitsService workpermitsService):base(navigationService)
        {
            _workpermitsService = workpermitsService;
        }

        private ObservableCollection<WorkPermit> _workpermits;
        public ObservableCollection<WorkPermit> WorkPermits
        {
            get { return _workpermits; }
            set { SetProperty(ref _workpermits, value); }
        }
        public DelegateCommand<string> SearchCommand => _searchCommand ?? (_searchCommand = new DelegateCommand<string>(Search));

        private async void Search(string query)
        {
           
           var result = await _workpermitsService.SearchAsync(query);
            if (result != null)
            {
                WorkPermits = new ObservableCollection<WorkPermit>();
                foreach (var item in result)
                {
                    WorkPermits.Add(item);
                }
            }
        }
    }
}
