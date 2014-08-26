using AzureOfflineSyncXF.Services;
using AzureOfflineSyncXF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AzureOfflineSyncXF
{
    public class App
    {
        public static Page GetMainPage()
        {
            // Initial, once off data load
            LoadData();

            NavigationPage theNavigationPage = null;
            ContentPage theContentPage = null;

            try
            {
                theContentPage = new ContactListView();
                theNavigationPage = new NavigationPage(theContentPage);
            }
            catch(Exception ex)
            {
                // Do something with the exception
            }

            return theNavigationPage;
        }

        private static async void LoadData()
        {
            // First time through just make sure that this has completed
            await ServiceLocator.DataService.LoadContacts();
        }
    }
}
