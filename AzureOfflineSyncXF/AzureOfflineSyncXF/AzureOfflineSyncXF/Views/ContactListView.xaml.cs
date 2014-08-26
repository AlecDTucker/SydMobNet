using AzureOfflineSyncXF.ViewModels;
using System;
using System.Collections.Generic;
namespace AzureOfflineSyncXF.Views
{
    public partial class ContactListView
    {
        public ContactListView()
        {
            InitializeComponent();
            this.BindingContext = ViewModelLocator.ContactListViewModel;
        }
    }
}
