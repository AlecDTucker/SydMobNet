namespace AzureOfflineSyncXF.ViewModels
{
    public static class ViewModelLocator
    {
        private static ContactListViewModel _contactListViewModel = null;
        public static ContactListViewModel ContactListViewModel
        {
            get 
            {
                if (_contactListViewModel == null)
                {
                    _contactListViewModel = new ContactListViewModel();
                }
                return _contactListViewModel; 
            }
        }
        
    }
}
