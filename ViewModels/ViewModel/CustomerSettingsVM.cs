using ViewModels.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.ViewModel
{
    class CustomerSettingsVM : ObservableObject
    {

        private CustomerVM _customer;
        public CustomerVM SelectedCustomer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                RaisePropertyChangedEvent("SelectedCustomer");
            }
        }
    }
}
