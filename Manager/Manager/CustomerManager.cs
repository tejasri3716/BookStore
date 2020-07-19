using Manager.IManager;
using Model.CustomerModel;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    public class CustomerManager : ICustomerManager
    {
        private readonly ICustomerRepo customer;

        public CustomerManager(ICustomerRepo customer)
        {
            this.customer = customer;
        }
        public async Task<int> AddCustomerDetails(CustomerModels customerModel)
        {
            return await this.customer.AddCustomerDetails(customerModel);

        }

        public async Task<int> DeleteCustomerDetails(int id)
        {
            return await this.customer.DeleteCustomerDetails(id);
        }

        public List<CustomerModels> GetCustomerDetails(string email)
        {
            return this.customer.GetCustomerDetails(email);
        }

        public async Task<int> UpdateCustomerDetails(CustomerModels customerModel)
        {
            return await this.customer.UpdateCustomerDetails(customerModel);
        }
    }
}
