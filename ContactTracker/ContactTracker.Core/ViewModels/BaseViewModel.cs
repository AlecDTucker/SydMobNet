using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTracker.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        private string _smallTitle;
        public string SmallTitle
        {
            get { return _smallTitle; }
            set { if (_smallTitle != value) { _smallTitle = value; RaisePropertyChanged(() => SmallTitle); } }
        }
        private string _bigTitle;
        public string BigTitle
        {
            get { return _bigTitle; }
            set { if (_bigTitle != value) { _bigTitle = value; RaisePropertyChanged(() => BigTitle); } }
        }
    }
}
