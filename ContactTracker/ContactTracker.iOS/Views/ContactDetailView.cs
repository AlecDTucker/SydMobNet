using System;
using System.Drawing;

using MonoTouch.CoreFoundation;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using Cirrious.MvvmCross.Touch.Views;
using ContactTracker.Core.ViewModels;
using Cirrious.MvvmCross.Binding.BindingContext;


namespace ContactTracker.iOS.Views
{
    [Register("ContactDetailView")]
    public class ContactDetailView : MvxViewController
    {
        public ContactDetailView()
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
            View = new UIView() { BackgroundColor = UIColor.White };
            base.ViewDidLoad();

            if (ViewModel != null && ViewModel is ContactDetailViewModel)
            {
                this.Title = ((ContactDetailViewModel)ViewModel).BigTitle;
            }

            // Perform any additional setup after loading the view
            var labelFirstName = new UILabel(new RectangleF(10, 70, 300, 20));
            labelFirstName.Font = UIFont.FromName("Helvetica", 12f);
            Add(labelFirstName);
            var textFieldFirstName = new UITextField(new RectangleF(10, 90, 300, 40));
            Add(textFieldFirstName);

            var labelLastName = new UILabel(new RectangleF(10, 130, 300, 20));
            labelLastName.Font = UIFont.FromName("Helvetica", 12f);
            Add(labelLastName);
            var textFieldLastName = new UITextField(new RectangleF(10, 150, 300, 40));
            Add(textFieldLastName);

            var labelEmail = new UILabel(new RectangleF(10, 190, 300, 20));
            labelEmail.Font = UIFont.FromName("Helvetica", 12f);
            Add(labelEmail);
            var textFieldEmail = new UITextField(new RectangleF(10, 210, 300, 40));
            Add(textFieldEmail);

            var set = this.CreateBindingSet<ContactDetailView, Core.ViewModels.ContactDetailViewModel>();
            set.Bind(labelFirstName).To(vm => vm.FirstNameLabel);
            set.Bind(textFieldFirstName).To(vm => vm.Contact.FirstName);
            set.Bind(labelLastName).To(vm => vm.LastNameLabel);
            set.Bind(textFieldLastName).To(vm => vm.Contact.LastName);
            set.Bind(labelEmail).To(vm => vm.EmailLabel);
            set.Bind(textFieldEmail).To(vm => vm.Contact.Email);

            set.Apply();

        }
    }
}