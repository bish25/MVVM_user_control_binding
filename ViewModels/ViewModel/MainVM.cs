using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data.Common;
using System.ComponentModel;
using System.Windows.Controls;
using ViewModels.View;

namespace ViewModels.ViewModel
{
    class MainVM : ObservableObject
    {
        private readonly string _title = "CUSTOMERS";
        private  CustomersVM _customerVM;
        private SuppliersVM _supplierVM;
        private UserControl _content;

        public string Title { get { return _title; } }
        

        public MainVM()
        {
            Customer = new CustomersVM();
            Supplier = new SuppliersVM();
            SelectedMain = Customer;
            _content = new CustomerSettings();
            _content.DataContext = Customer;
            SettingsControl = _content;
            
        }

        public CustomersVM Customer
        {
            get { return _customerVM; }
            private set { _customerVM = value; }
        }

        public SuppliersVM Supplier
        {
            get { return _supplierVM; }
            private set { _supplierVM = value; }
        }

        public UserControl SettingsControl
        {
            get { return _content; }
            set
            {
                _content = value;
                RaisePropertyChangedEvent("SettingsControl");
            }
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
                    _content = new CustomerSettings();
                    _content.DataContext = Customer;
                    SettingsControl = _content;
                    break;
                case "1":
                    SelectedMain = Supplier;
                    _content = new SupplierSettings();
                    _content.DataContext = Supplier;
                    SettingsControl = _content;
                    break;
            }
            
        }
    }
}
