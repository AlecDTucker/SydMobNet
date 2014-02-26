using ContactTracker.Core.Models;
using ContactTracker.Core.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTracker.Core.ViewModels
{
    public class ContactListViewModel : BaseViewModel
    {
        private readonly IDataService _dataService;
        private bool isRefreshing = false;

        public ContactListViewModel( IDataService pDataService )
        {
            _dataService = pDataService;

            this.SmallTitle = "CONTACT TRACKER";
            this.BigTitle = "contacts";
        }

        #region MvxProperties
        private ObservableCollection<Contact> _contacts;
        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts; }
            set { if (_contacts != value) { _contacts = value; RaisePropertyChanged(() => Contacts); } }
        }

        private Contact _selectedContact;
        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set { if (_selectedContact != value) { _selectedContact = value; RaisePropertyChanged(() => SelectedContact); } }
        }
        #endregion

        #region Command and associated method for RefreshListCommand
        private Cirrious.MvvmCross.ViewModels.MvxCommand _refreshListCommand;
        /// <summary>
        /// If the associated UI control supports command binding, bind to this
        /// </summary>
        public System.Windows.Input.ICommand RefreshListCommand
        {
            get
            {
                _refreshListCommand = _refreshListCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(DoRefreshListCommand);
                return _refreshListCommand;
            }
        }
        /// <summary>
        /// This is called by the command.
        /// If the associated UI control does not support command binding then call this directly
        /// from the event handler in the code behind (this is why it's public not private)
        /// </summary>
        public async void DoRefreshListCommand()
        {
            // Do action
            isRefreshing = true;
            this.Contacts = new ObservableCollection<Contact>(await _dataService.LoadContacts());
            isRefreshing = false;
        }
        #endregion

        #region Command and associated method for ShowContactCommand
        private Cirrious.MvvmCross.ViewModels.MvxCommand<Contact> _showContactCommand;
        /// <summary>
        /// If the associated UI control supports command binding, bind to this
        /// </summary>
        public System.Windows.Input.ICommand ShowContactCommand
        {
            get
            {
                _showContactCommand = _showContactCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand<Contact>(DoShowContactCommand);
                return _showContactCommand;
            }
        }
        /// <summary>
        /// This is called by the command.
        /// If the associated UI control does not support command binding then call this directly
        /// from the event handler in the code behind (this is why it's public not private)
        /// </summary>
        public void DoShowContactCommand(Contact pContact)
        {
            // Do action
            if (!isRefreshing)
            {
                ShowViewModel<ContactDetailViewModel>(pContact);
            }
        }
        #endregion
    }
}
