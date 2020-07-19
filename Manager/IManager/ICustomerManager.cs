using Model.CustomerModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.IManager
{
    public interface ICustomerManager
    {
        Task<int> AddCustomerDetails(CustomerModels customerModel);
        Task<int> DeleteCustomerDetails(int id);
        Task<int> UpdateCustomerDetails(CustomerModels customerModel);
        List<CustomerModels> GetCustomerDetails(string email);
    }
}
