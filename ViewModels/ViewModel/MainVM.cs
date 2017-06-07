using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data.Common;
using System.ComponentModel;

namespace ViewModels.ViewModel
{
    class MainVM : ObservableObject
    {
        private readonly string _title = "CUSTOMERS";
        private  CustomerVM _customerVM;
        private CustomerSettingsVM _customerSettingsVM;
     

        public string Title { get { return _title; } }
        

        public MainVM()
        {
            Customer = new CustomerVM();
            CustomerSettings = new CustomerSettingsVM();
            SelectedMain = Customer;
            SelectedSettings = CustomerSettings;
        }

        public CustomerVM Customer
        {
            get { return _customerVM; }
            private set { _customerVM = value; }
        }
        public CustomerSettingsVM CustomerSettings
        {
            get { return _customerSettingsVM; }
            private set { _customerSettingsVM = value; }
        }

    

        public INotifyPropertyChanged _selectedMain;
        public INotifyPropertyChanged SelectedMain
        {
            get { return _selectedMain; }
            set
            {
                if (value != _selectedMain)
                {
                    _selectedMain = value;
                    RaisePropertyChangedEvent("SelectedMain");
                }
            }
        }
        public INotifyPropertyChanged _selectedSettings;
        public INotifyPropertyChanged SelectedSettings
        {
            get { return _selectedSettings; }
            set
            {
                if (value != _selectedSettings)
                {
                    _selectedSettings = value;
                    RaisePropertyChangedEvent("SelectedSettings");
                }
            }
        }

        public ICommand NavigationCommand
        {
            get { return new DelegateCommand(Navigate); }
        }

        public void Navigate(object obj)
        {
            switch (obj.ToString())
            {
                case "0":
                    SelectedMain = Customer;
                    SelectedSettings = Customer;
                    break;
                case "1":
                   
                    break;
            }
            
        }
    }
}
