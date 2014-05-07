using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using Cirrious.MvvmCross.Binding.Touch.Views;
using SydMobNet2.AMS.Core.ViewModels;

namespace SydMobNet2.AMS.iOS.Views
{
    [Register("FirstView")]
    public class FirstView : MvxTableViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view
            if (ViewModel != null && ViewModel is FirstViewModel)
            {
                ((FirstViewModel)ViewModel).LoadContacts();
                this.Title = "contacts";
            }

            // Standard uses one of the 4 basic generic iOS templates. Gives a standard cell for every item in the list.
            var source = new MvxStandardTableViewSource(TableView, "TitleText LastName;ImageUrl ImageUrl");
            TableView.Source = source;

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(source).To(vm => vm.Contacts);
            set.Apply();

            TableView.ReloadData();
        }
    }
}