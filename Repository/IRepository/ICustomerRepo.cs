using Model.CustomerModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface ICustomerRepo
   {
        Task<int> AddCustomerDetails(CustomerModels customerModel);
        Task<int> DeleteCustomerDetails(int id);
        Task<int> UpdateCustomerDetails(CustomerModels customerModel);
        List<CustomerModels> GetCustomerDetails(string email);
    }
}
