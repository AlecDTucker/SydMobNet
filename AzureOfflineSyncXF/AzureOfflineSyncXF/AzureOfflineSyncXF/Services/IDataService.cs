using System;
namespace AzureOfflineSyncXF.Services
{
    public interface IDataService
    {
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<T>> GetAll<T>();
        System.Threading.Tasks.Task LoadContacts();
        System.Threading.Tasks.Task Pull<T>();
        System.Threading.Tasks.Task Save<T>(T pEntity);
    }
}
