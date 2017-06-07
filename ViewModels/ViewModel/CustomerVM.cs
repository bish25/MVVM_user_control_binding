using ViewModels.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModels.Factory;

namespace ViewModels.ViewModel
{
    class CustomerVM : ObservableObject
    {
        private string _searchText;
        private Customer _selectedCustomer;
        private readonly ObservableCollection<Customer> _customers = DatabaseMaster.GetCustomers();
        public string Title = "Customers";

        public CustomerVM()
        {
            
        }
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                RaisePropertyChangedEvent("SearchText");
            }
        }

        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                RaisePropertyChangedEvent("SelectedCustomer");
            }
        }

        public IEnumerable<Customer> Customers
        {
            get { return _customers; }
        }

        

        public ICommand LoadCustomersCommand
        {
            get { return new DelegateCommand(LoadCustomers); }
        }

        public void LoadCustomers(object obj)
        {
   

        }
    }
}
