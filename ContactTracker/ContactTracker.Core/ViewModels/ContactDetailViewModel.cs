using ContactTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTracker.Core.ViewModels
{
    public class ContactDetailViewModel : BaseViewModel
    {
        public ContactDetailViewModel()
        {
            this.SmallTitle = "CONTACT TRACKER";
            this.BigTitle = "contact";
        }

        public void Init(Contact pContact)
        {
            this.Contact = pContact;
        }

        private Contact _contact;
        public Contact Contact
        {
            get { return _contact; }
            set { if (_contact != value) { _contact = value; RaisePropertyChanged(() => Contact); } }
        }

        private string _firstNameLabel;
        public string FirstNameLabel
        {
            get { _firstNameLabel = "First Name"; return _firstNameLabel; }
            set { if (_firstNameLabel != value) { _firstNameLabel = value; RaisePropertyChanged(() => FirstNameLabel); } }
        }

        private string _lastNameLabel;
        public string LastNameLabel
        {
            get { _lastNameLabel = "Last Name"; return _lastNameLabel; }
            set { if (_lastNameLabel != value) { _lastNameLabel = value; RaisePropertyChanged(() => LastNameLabel); } }
        }

        private string _emailLabel;
        public string EmailLabel
        {
            get { _emailLabel = "Email"; return _emailLabel; }
            set { if (_emailLabel != value) { _emailLabel = value; RaisePropertyChanged(() => EmailLabel); } }
        }

        private string _phoneNumberLabel;
        public string PhoneNumberLabel
        {
            get { _phoneNumberLabel = "Phone"; return _phoneNumberLabel; }
            set { if (_phoneNumberLabel != value) { _phoneNumberLabel = value; RaisePropertyChanged(() => PhoneNumberLabel); } }
        }
    }
}
