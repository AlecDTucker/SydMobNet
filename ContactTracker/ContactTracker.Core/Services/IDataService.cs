using System;
namespace ContactTracker.Core.Services
{
    public interface IDataService
    {
        System.Threading.Tasks.Task<System.Collections.Generic.List<ContactTracker.Core.Models.Contact>> LoadContacts();
    }
}
