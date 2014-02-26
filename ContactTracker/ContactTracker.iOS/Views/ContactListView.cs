using System;
using System.Drawing;

using MonoTouch.CoreFoundation;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using Cirrious.MvvmCross.Touch.Views;
using ContactTracker.Core.ViewModels;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;


namespace ContactTracker.iOS.Views
{
    [Register("ContactListView")]
    public class ContactListView : MvxTableViewController
    {
        public ContactListView()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view
            if (ViewModel != null && ViewModel is ContactListViewModel)
            {
                ((ContactListViewModel)ViewModel).DoRefreshListCommand();
                this.Title = ((ContactListViewModel)ViewModel).BigTitle;
            }

            // Standard uses one of the 4 basic generic iOS templates. Gives a standard cell for every item in the list.
            var source = new MvxStandardTableViewSource(TableView, "TitleText LastName");
            TableView.Source = source;

            var set = this.CreateBindingSet<ContactListView, ContactListViewModel>();
            set.Bind(source).To(vm => vm.Contacts);
            set.Bind(source).For(s => s.SelectionChangedCommand).To(vm => vm.ShowContactCommand);
            set.Apply();

            TableView.ReloadData();

        }
    }
}