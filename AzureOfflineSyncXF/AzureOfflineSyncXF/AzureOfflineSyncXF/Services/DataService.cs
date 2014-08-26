using AzureOfflineSyncXF.Models;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureOfflineSyncXF.Services
{
    public class DataService : AzureOfflineSyncXF.Services.IDataService
    {
        private readonly MobileServiceClient MobileService = new MobileServiceClient("[your url here]", "[your key here]");

        public DataService()
        {
            Initialise();
        }
        private async void Initialise()
        {
            if (!MobileService.SyncContext.IsInitialized)
            {
                var store = new MobileServiceSQLiteStore("local.db");
                store.DefineTable<AzureOfflineSyncXF.Models.Contact>();
                await MobileService.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());
                await Pull<AzureOfflineSyncXF.Models.Contact>();
            }
        }
        public async Task<ObservableCollection<T>> GetAll<T>()
        {
            ObservableCollection<T> theCollection = new ObservableCollection<T>();

            try
            {
                //var theTable = MobileService.GetTable<T>();
                var theTable = MobileService.GetSyncTable<T>();
                theCollection = await theTable.ToCollectionAsync<T>();
            }
            catch (Exception ex)
            {
                theCollection = null;
                ReportError(ex);
            }

            return theCollection;
        }
        public async Task Save<T>(T pEntity)
        {
            try
            {
                //var theTable = MobileService.GetTable<T>();
                var theTable = MobileService.GetSyncTable<T>();
                await theTable.InsertAsync(pEntity);
            }
            catch (Exception ex)
            {
                ReportError(ex);
            }
        }
        public async Task Pull<T>()
        {
            try
            {
                var theTable = MobileService.GetSyncTable<T>();
                await theTable.PullAsync();
            }
            catch (Exception ex)
            {
                ReportError(ex);
            }
        }

        public async Task LoadContacts()
        {
            Collection<Contact> theList = new Collection<Contact>();

            theList.Add(new Contact() { FirstName = "George", LastName = "Washington", Email = "George@fake.com", PhoneNumber = "02 555 1111" });
            theList.Add(new Contact() { FirstName = "John", LastName = "Adams", Email = "John@fake.com", PhoneNumber = "02 555 1112" });
            theList.Add(new Contact() { FirstName = "Thomas", LastName = "Jefferson", Email = "Thomas@fake.com", PhoneNumber = "02 555 1113" });
            theList.Add(new Contact() { FirstName = "James", LastName = "Madison", Email = "James@fake.com", PhoneNumber = "02 555 1114" });
            theList.Add(new Contact() { FirstName = "James", LastName = "Monroe", Email = "James@fake.com", PhoneNumber = "02 555 1115" });
            theList.Add(new Contact() { FirstName = "John Quincy", LastName = "Adams", Email = "John@fake.com", PhoneNumber = "02 555 1116" });
            theList.Add(new Contact() { FirstName = "Andrew", LastName = "Jackson", Email = "Andrew@fake.com", PhoneNumber = "02 555 1117" });
            theList.Add(new Contact() { FirstName = "Martin", LastName = "van Buren", Email = "Martin@fake.com", PhoneNumber = "02 555 1118" });
            theList.Add(new Contact() { FirstName = "William Henry", LastName = "Harrison", Email = "William@fake.com", PhoneNumber = "02 555 1119" });
            theList.Add(new Contact() { FirstName = "John", LastName = "Tyler", Email = "John@fake.com", PhoneNumber = "02 555 1120" });
            theList.Add(new Contact() { FirstName = "James K.", LastName = "Polk", Email = "James@fake.com", PhoneNumber = "02 555 1121" });
            theList.Add(new Contact() { FirstName = "Zachary", LastName = "Taylor", Email = "Zachary@fake.com", PhoneNumber = "02 555 1122" });
            theList.Add(new Contact() { FirstName = "Millard", LastName = "Filmore", Email = "Millard@fake.com", PhoneNumber = "02 555 1123" });
            theList.Add(new Contact() { FirstName = "Franklin", LastName = "Pierce", Email = "Franklin@fake.com", PhoneNumber = "02 555 1124" });
            theList.Add(new Contact() { FirstName = "James", LastName = "Buchanan", Email = "James@fake.com", PhoneNumber = "02 555 1125" });
            theList.Add(new Contact() { FirstName = "Abraham", LastName = "Lincoln", Email = "Abraham@fake.com", PhoneNumber = "02 555 1126" });
            theList.Add(new Contact() { FirstName = "Andrew", LastName = "Johnson", Email = "Andrew@fake.com", PhoneNumber = "02 555 1127" });
            theList.Add(new Contact() { FirstName = "Ulysees S.", LastName = "Grant", Email = "Ulysees@fake.com", PhoneNumber = "02 555 1128" });
            theList.Add(new Contact() { FirstName = "Rutherford B.", LastName = "Hayes", Email = "Rutherford@fake.com", PhoneNumber = "02 555 1129" });
            theList.Add(new Contact() { FirstName = "James A.", LastName = "Garield", Email = "James@fake.com", PhoneNumber = "02 555 1130" });
            theList.Add(new Contact() { FirstName = "Chester A.", LastName = "Arthur", Email = "Chester@fake.com", PhoneNumber = "02 555 1131" });
            theList.Add(new Contact() { FirstName = "Grover", LastName = "Cleveland", Email = "Grover@fake.com", PhoneNumber = "02 555 1132" });
            theList.Add(new Contact() { FirstName = "Benjamin", LastName = "Harrison", Email = "Benjamin@fake.com", PhoneNumber = "02 555 1133" });
            theList.Add(new Contact() { FirstName = "Grover", LastName = "Cleveland", Email = "Grover@fake.com", PhoneNumber = "02 555 1134" });
            theList.Add(new Contact() { FirstName = "William", LastName = "McKinley", Email = "William@fake.com", PhoneNumber = "02 555 1135" });
            theList.Add(new Contact() { FirstName = "Theodore", LastName = "Roosevelt", Email = "Theodore@fake.com", PhoneNumber = "02 555 1136" });
            theList.Add(new Contact() { FirstName = "William Howard", LastName = "Taft", Email = "William@fake.com", PhoneNumber = "02 555 1137" });
            theList.Add(new Contact() { FirstName = "Woodrow", LastName = "Wilson", Email = "Woodrow@fake.com", PhoneNumber = "02 555 1138" });
            theList.Add(new Contact() { FirstName = "Warren G.", LastName = "Harding", Email = "Warren@fake.com", PhoneNumber = "02 555 1139" });
            theList.Add(new Contact() { FirstName = "Calvin", LastName = "Coolidge", Email = "Calvin@fake.com", PhoneNumber = "02 555 1140" });
            theList.Add(new Contact() { FirstName = "Herbert", LastName = "Hoover", Email = "Herbert@fake.com", PhoneNumber = "02 555 1141" });
            theList.Add(new Contact() { FirstName = "Franklin D.", LastName = "Roosevelt", Email = "Franklin@fake.com", PhoneNumber = "02 555 1142" });
            theList.Add(new Contact() { FirstName = "Calvin", LastName = "Coolidge", Email = "Calvin@fake.com", PhoneNumber = "02 555 1143" });
            theList.Add(new Contact() { FirstName = "Harry S.", LastName = "Truman", Email = "Harry@fake.com", PhoneNumber = "02 555 1144" });
            theList.Add(new Contact() { FirstName = "Dwight D.", LastName = "Eisenhower", Email = "Dwight@fake.com", PhoneNumber = "02 555 1145" });
            theList.Add(new Contact() { FirstName = "John F.", LastName = "Kennedy", Email = "John@fake.com", PhoneNumber = "02 555 1146" });
            theList.Add(new Contact() { FirstName = "Lyndon B.", LastName = "Johnson", Email = "Lyndon@fake.com", PhoneNumber = "02 555 1147" });
            theList.Add(new Contact() { FirstName = "Richard", LastName = "Nixon", Email = "Richard@fake.com", PhoneNumber = "02 555 1148" });
            theList.Add(new Contact() { FirstName = "Gerald", LastName = "Ford", Email = "Gerald@fake.com", PhoneNumber = "02 555 1149" });
            theList.Add(new Contact() { FirstName = "Jimmy", LastName = "Carter", Email = "Jimmy@fake.com", PhoneNumber = "02 555 1150" });
            theList.Add(new Contact() { FirstName = "Ronald", LastName = "Reagan", Email = "Ronald@fake.com", PhoneNumber = "02 555 1151" });
            theList.Add(new Contact() { FirstName = "George H.W.", LastName = "Bush", Email = "George@fake.com", PhoneNumber = "02 555 1152" });
            theList.Add(new Contact() { FirstName = "Bill", LastName = "Clinton", Email = "Bill@fake.com", PhoneNumber = "02 555 1153" });
            theList.Add(new Contact() { FirstName = "George W.", LastName = "Bush", Email = "George@fake.com", PhoneNumber = "02 555 1154" });
            theList.Add(new Contact() { FirstName = "Barack", LastName = "Obama", Email = "Barack@fake.com", PhoneNumber = "02 555 1155" });

            foreach(Contact one in theList)
            {
                await this.Save<Contact>(one);
            }
        }

        private void ReportError(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
