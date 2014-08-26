using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AzureOfflineSyncXF.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Property change notification stuff
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            RaisePropertyChangedExplicit(propertyName);
        }
        protected void RaisePropertyChanged<TProperty>(Expression<Func<TProperty>> projection)
        {
            var memberExpression = (MemberExpression)projection.Body;
            RaisePropertyChangedExplicit(memberExpression.Member.Name);
        }
        void RaisePropertyChangedExplicit(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
        #endregion

        #region Base Properties
        private string _smallTitle = String.Empty;
        public string SmallTitle
        {
            get { return _smallTitle; }
            set { if (_smallTitle != value) { _smallTitle = value; RaisePropertyChanged(() => SmallTitle); } }
        }

        private string _bigTitle = String.Empty;
        public string BigTitle
        {
            get { return _bigTitle; }
            set { if (_bigTitle != value) { _bigTitle = value; RaisePropertyChanged(() => BigTitle); } }
        }

        private bool _isBusy = false;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { if (_isBusy != value) { _isBusy = value; RaisePropertyChanged(() => IsBusy); } }
        }

        private string _busyMessage = String.Empty;
        public string BusyMessage
        {
            get { return _busyMessage; }
            set { if (_busyMessage != value) { _busyMessage = value; RaisePropertyChanged(() => BusyMessage); } }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Set the busy indicator and the busy message
        /// </summary>
        /// <param name="pIsBusy"></param>
        /// <param name="pBusyMessage"></param>
        public void SetBusy(bool pIsBusy, string pBusyMessage)
        {
            this.IsBusy = pIsBusy;
            this.BusyMessage = pBusyMessage;
        }
        /// <summary>
        /// Set the busy indicator and clear the busy message - designed for switching busy off
        /// </summary>
        /// <param name="pIsBusy"></param>
        public void SetBusy(bool pIsBusy)
        {
            this.IsBusy = pIsBusy;
            this.BusyMessage = String.Empty;
        }
        #endregion
    }
}
