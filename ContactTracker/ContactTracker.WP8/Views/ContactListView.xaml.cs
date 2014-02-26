using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ContactTracker.Core.ViewModels;
using ContactTracker.Core.Models;
using Cirrious.MvvmCross.WindowsPhone.Views;

namespace ContactTracker.WP8.Views
{
    public partial class ContactListView : MvxPhonePage
    {
        public ContactListView()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (ViewModel != null && ViewModel is ContactListViewModel)
            {
                ((ContactListViewModel)ViewModel).DoRefreshListCommand();
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ViewModel != null && ViewModel is ContactListViewModel)
            {
                ((ContactListViewModel)ViewModel).DoShowContactCommand((Contact)lbContacts.SelectedItem);
            }
        }
    }
}