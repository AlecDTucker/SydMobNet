using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Views;
using ContactTracker.Core.ViewModels;

namespace ContactTracker.Droid.Views
{
    [Activity(Label = "View for ContactListViewModel")]
    public class ContactListView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.ContactListView);

            if (ViewModel != null && ViewModel is ContactListViewModel)
            {
                this.Title = ((ContactListViewModel)ViewModel).BigTitle;
                ((ContactListViewModel)ViewModel).DoRefreshListCommand();
            }

        }
    }
}