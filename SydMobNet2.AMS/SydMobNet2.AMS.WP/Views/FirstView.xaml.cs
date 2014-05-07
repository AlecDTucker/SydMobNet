using Cirrious.MvvmCross.WindowsPhone.Views;
using SydMobNet2.AMS.Core.ViewModels;

namespace SydMobNet2.AMS.WP.Views
{
    public partial class FirstView : MvxPhonePage
    {
        public FirstView()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (ViewModel != null && ViewModel is FirstViewModel)
            {
                ((FirstViewModel)ViewModel).LoadContacts();
            }
        }
    }
}