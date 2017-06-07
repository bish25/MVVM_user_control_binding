using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using System.Diagnostics;
using System.Threading;
using ViewModels.Model;

namespace ViewModels.Factory
{
    class DatabaseMaster
    {
        
        //get clients
        public static ObservableCollection<Customer> GetCustomers()
        {
            ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
            for(int i = 0; i < 10000; i++)
            {
                Random rnd = new Random();
                int number = rnd.Next();
                customers.Add(new Customer { id = i, name = "Sam"+i, address1 = "address line 1", address2 = "Address Line 2", town = "Town", county = "County", postcode = "Postcode", phone = "01248 458 458", email = "email@email.com"   });
            }
            
            return customers;
        }

        public static bool CheckConnection(SqlConnection con)
        {
            bool result = false;
            try
            {
                con.Open();
                result = true;
                con.Close();
            }
            catch (SqlException sqlError)
            {
                result = false;
                Trace.TraceError(sqlError.Message);
            }
            return result;
        }
    }
}
