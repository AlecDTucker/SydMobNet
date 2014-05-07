using System;
namespace SydMobNet2.AMS.Core.Services
{
    public interface ICloudService
    {
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<SydMobNet2.AMS.Core.Models.Contact>> GetAll();
        System.Threading.Tasks.Task SaveAll(System.Collections.ObjectModel.ObservableCollection<SydMobNet2.AMS.Core.Models.Contact> entities);
    }
}
