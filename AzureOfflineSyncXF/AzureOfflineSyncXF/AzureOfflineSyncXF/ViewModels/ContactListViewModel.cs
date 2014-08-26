using AzureOfflineSyncXF.Models;
using AzureOfflineSyncXF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureOfflineSyncXF.ViewModels
{
    public class ContactListViewModel : BaseViewModel
    {
        private readonly IDataService _dataService;

        public ContactListViewModel()
        {
            _dataService = ServiceLocator.DataService;
            _constructor();
        }
        public ContactListViewModel(IDataService pDataService)
        {
            // Shown to demo injection support
            _dataService = pDataService;
            _constructor();
        }
        private async void _constructor()
        {
            this.Contacts = await LoadContacts();
        }

        private ObservableCollection<Contact> _contacts;
        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts; }
            set { if (_contacts != value) { _contacts = value; RaisePropertyChanged(() => Contacts); } }
        }

        private async Task<ObservableCollection<Contact>> LoadContacts()
        {
            ObservableCollection<Contact> theCollection = new ObservableCollection<Contact>();

            try
            {
                theCollection = await _dataService.GetAll<Contact>();
            }
            catch(Exception ex)
            {
                theCollection = null;

                // Do something with the exception
            }

            return theCollection;
        }
    }
}
