namespace AzureOfflineSyncXF.Services
{
    public static class ServiceLocator
    {
        private static IDataService _dataService = null;
        public static IDataService DataService
        {
            get 
            {
                if (_dataService == null)
                {
                    _dataService = new DataService();
                }
                return _dataService; 
            }
        }
        
    }
}
