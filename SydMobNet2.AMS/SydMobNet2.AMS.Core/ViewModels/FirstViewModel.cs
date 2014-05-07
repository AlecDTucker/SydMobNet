using Cirrious.MvvmCross.ViewModels;
using SydMobNet2.AMS.Core.Models;
using SydMobNet2.AMS.Core.Services;
using System.Collections.ObjectModel;

namespace SydMobNet2.AMS.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        private readonly ICloudService _cloudService;

        public FirstViewModel(ICloudService pCloudService)
        {
            _cloudService = pCloudService;
        }

		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        private ObservableCollection<Contact> _contacts;
        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts; }
            set { if (_contacts != value) { _contacts = value; RaisePropertyChanged(() => Contacts); } }
        }

        public void PopulateContacts()
        {
            ObservableCollection<Contact> newContacts = new ObservableCollection<Contact>();

            newContacts.Add(new Contact() { FirstName = "George", LastName = "Washington", Email = "George@fake.com", PhoneNumber = "02 555 1111", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/X/9/washington.jpg" });
            newContacts.Add(new Contact() { FirstName = "John", LastName = "Adams", Email = "John@fake.com", PhoneNumber = "02 555 1112", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/a/9/2_adams.jpg" });
            newContacts.Add(new Contact() { FirstName = "Thomas", LastName = "Jefferson", Email = "Thomas@fake.com", PhoneNumber = "02 555 1113", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/Z/9/t_jefferson.jpg" });
            newContacts.Add(new Contact() { FirstName = "James", LastName = "Madison", Email = "James@fake.com", PhoneNumber = "02 555 1114", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/b/9/4_madison.jpg" });
            newContacts.Add(new Contact() { FirstName = "James", LastName = "Monroe", Email = "James@fake.com", PhoneNumber = "02 555 1115", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/c/9/5_monroe.jpg" });
            newContacts.Add(new Contact() { FirstName = "John Quincy", LastName = "Adams", Email = "John@fake.com", PhoneNumber = "02 555 1116", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/d/9/6_john_q_adams_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Andrew", LastName = "Jackson", Email = "Andrew@fake.com", PhoneNumber = "02 555 1117", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/V/9/Andrew_jackson_head.gif" });
            newContacts.Add(new Contact() { FirstName = "Martin", LastName = "van Buren", Email = "Martin@fake.com", PhoneNumber = "02 555 1118", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/e/9/8_van_buren_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "William Henry", LastName = "Harrison", Email = "William@fake.com", PhoneNumber = "02 555 1119", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/f/9/9_william_harrison.jpg" });
            newContacts.Add(new Contact() { FirstName = "John", LastName = "Tyler", Email = "John@fake.com", PhoneNumber = "02 555 1120", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/g/9/10_john_tyler_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "James K.", LastName = "Polk", Email = "James@fake.com", PhoneNumber = "02 555 1121", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/7/2/polk2.jpg" });
            newContacts.Add(new Contact() { FirstName = "Zachary", LastName = "Taylor", Email = "Zachary@fake.com", PhoneNumber = "02 555 1122", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/h/9/12_z_taylor_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Millard", LastName = "Filmore", Email = "Millard@fake.com", PhoneNumber = "02 555 1123", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/i/9/13_fillmore_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Franklin", LastName = "Pierce", Email = "Franklin@fake.com", PhoneNumber = "02 555 1124", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/j/9/14_pierce_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "James", LastName = "Buchanan", Email = "James@fake.com", PhoneNumber = "02 555 1125", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/k/9/15_buchanan_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Abraham", LastName = "Lincoln", Email = "Abraham@fake.com", PhoneNumber = "02 555 1126", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/l/9/16_lincoln_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Andrew", LastName = "Johnson", Email = "Andrew@fake.com", PhoneNumber = "02 555 1127", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/6/2/andrewjohnson1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Ulysees S.", LastName = "Grant", Email = "Ulysees@fake.com", PhoneNumber = "02 555 1128", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/m/9/18_grant_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Rutherford B.", LastName = "Hayes", Email = "Rutherford@fake.com", PhoneNumber = "02 555 1129", ImageUrl = "http://americanhistory.about.com/od/uspresidents/ig/Images-of-US-Presidents/Rutherford-B-Hayes.htm" });
            newContacts.Add(new Contact() { FirstName = "James A.", LastName = "Garield", Email = "James@fake.com", PhoneNumber = "02 555 1130", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/o/9/20_garfield_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Chester A.", LastName = "Arthur", Email = "Chester@fake.com", PhoneNumber = "02 555 1131", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/p/9/21_arthur_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Grover", LastName = "Cleveland", Email = "Grover@fake.com", PhoneNumber = "02 555 1132", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/q/9/22_cleveland_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Benjamin", LastName = "Harrison", Email = "Benjamin@fake.com", PhoneNumber = "02 555 1133", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/r/9/23_b_harrison_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Grover", LastName = "Cleveland", Email = "Grover@fake.com", PhoneNumber = "02 555 1134", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/q/9/22_cleveland_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "William", LastName = "McKinley", Email = "William@fake.com", PhoneNumber = "02 555 1135", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/s/9/25_w_mckinley.jpg" });
            newContacts.Add(new Contact() { FirstName = "Theodore", LastName = "Roosevelt", Email = "Theodore@fake.com", PhoneNumber = "02 555 1136", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/t/9/26_t_roosevelt_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "William Howard", LastName = "Taft", Email = "William@fake.com", PhoneNumber = "02 555 1137", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/u/9/27_taft_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Woodrow", LastName = "Wilson", Email = "Woodrow@fake.com", PhoneNumber = "02 555 1138", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/8/2/wilson2.jpg" });
            newContacts.Add(new Contact() { FirstName = "Warren G.", LastName = "Harding", Email = "Warren@fake.com", PhoneNumber = "02 555 1139", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/v/9/29_harding_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Calvin", LastName = "Coolidge", Email = "Calvin@fake.com", PhoneNumber = "02 555 1140", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/w/9/30_coolidge_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Herbert", LastName = "Hoover", Email = "Herbert@fake.com", PhoneNumber = "02 555 1141", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/8/A/31_hoover_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Franklin D.", LastName = "Roosevelt", Email = "Franklin@fake.com", PhoneNumber = "02 555 1142", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/x/9/32_fdr_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Calvin", LastName = "Coolidge", Email = "Calvin@fake.com", PhoneNumber = "02 555 1143", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/y/9/33_truman_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Harry S.", LastName = "Truman", Email = "Harry@fake.com", PhoneNumber = "02 555 1144", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/z/9/34_eisenhower_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Dwight D.", LastName = "Eisenhower", Email = "Dwight@fake.com", PhoneNumber = "02 555 1145", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/-/A/35_jfk_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "John F.", LastName = "Kennedy", Email = "John@fake.com", PhoneNumber = "02 555 1146", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/0/A/36_lbj_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Lyndon B.", LastName = "Johnson", Email = "Lyndon@fake.com", PhoneNumber = "02 555 1147", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/0/A/36_lbj_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Richard", LastName = "Nixon", Email = "Richard@fake.com", PhoneNumber = "02 555 1148", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/1/A/37_nixon_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Gerald", LastName = "Ford", Email = "Gerald@fake.com", PhoneNumber = "02 555 1149", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/2/A/38_ford_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Jimmy", LastName = "Carter", Email = "Jimmy@fake.com", PhoneNumber = "02 555 1150", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/3/A/39_carter_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Ronald", LastName = "Reagan", Email = "Ronald@fake.com", PhoneNumber = "02 555 1151", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/4/A/40_reagan.jpg" });
            newContacts.Add(new Contact() { FirstName = "George H.W.", LastName = "Bush", Email = "George@fake.com", PhoneNumber = "02 555 1152", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/5/A/41-georgebush_1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Bill", LastName = "Clinton", Email = "Bill@fake.com", PhoneNumber = "02 555 1153", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/6/A/42_clinton-1.jpg" });
            newContacts.Add(new Contact() { FirstName = "George W.", LastName = "Bush", Email = "George@fake.com", PhoneNumber = "02 555 1154", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/7/A/43_georgewbush-1.jpg" });
            newContacts.Add(new Contact() { FirstName = "Barack", LastName = "Obama", Email = "Barack@fake.com", PhoneNumber = "02 555 1155", ImageUrl = "http://0.tqn.com/d/americanhistory/1/0/I/B/b_obama.jpg" });

            _cloudService.SaveAll(newContacts);
        }

        public async void LoadContacts()
        {
            this.Contacts = await _cloudService.GetAll();

            // For demo purposes, if there are no contacts returned then put some there and call again
            if (this.Contacts == null || this.Contacts.Count == 0)
            {
                PopulateContacts();
                this.Contacts = await _cloudService.GetAll();
            }
        }
    }
}
