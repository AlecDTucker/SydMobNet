using Microsoft.WindowsAzure.MobileServices;
using SydMobNet2.AMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SydMobNet2.AMS.Core.Services
{
    public class CloudService : SydMobNet2.AMS.Core.Services.ICloudService
    {
        private readonly MobileServiceClient MobileService = new MobileServiceClient("https://sydmobnet.azure-mobile.net", "CPuPFhXUBOlgAJnFfjnxHRrVbdPdaN75");

        public async Task<ObservableCollection<Contact>> GetAll()
        {
            ObservableCollection<Contact> theCollection = new ObservableCollection<Contact>();

            try
            {
                var theTable = MobileService.GetTable<Contact>();
                theCollection = await theTable.ToCollectionAsync<Contact>();
            }
            catch (Exception ex)
            {
                ReportError(ex);
            }

            return theCollection;
        }

        public async Task SaveAll(ObservableCollection<Contact> entities)
        {
            if (entities != null && entities.Count > 0)
            {
                try
                {
                    var theTable = MobileService.GetTable<Contact>();

                    foreach(Contact one in entities)
                    {
                        await theTable.InsertAsync(one);
                    }
                }
                catch(Exception ex)
                {
                    ReportError(ex);
                }
            }
        }

        private void ReportError(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}

