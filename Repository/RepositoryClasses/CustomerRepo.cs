using Model.CustomerModel;
using Repository.Context;
using Repository.IRepository;
using Repository.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryClasses
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly UserContext user;
        public CustomerRepo(UserContext user)
        {
            this.user = user;
        }

        public async Task<int> AddCustomerDetails(CustomerModels customer)
        {
            CustomerModels model = new CustomerModels()
            {
                Name = customer.Name,
                PhoneNumber = customer.PhoneNumber,
                Pincode = customer.Pincode,
                Locality = customer.Locality,
                Landmark = customer.Landmark,
                Address = customer.Address,
                TypeOfLocation = customer.TypeOfLocation,
                Email = customer.Email,
                City = customer.City
            };
            await this.user.Customers.AddAsync(customer);
            return await this.user.SaveChangesAsync();
        }

        public async Task<int> DeleteCustomerDetails(int id)
        {
            var customer = this.user.Customers.Where(op =>
              op.Id == id).SingleOrDefault();
            if (customer != null)
            {
                this.user.Customers.Remove(customer);
            }
            return await this.user.SaveChangesAsync();
        }

        public async Task<int> UpdateCustomerDetails(CustomerModels customerModel)
        {
            var customer = this.user.Customers.Where(op => op.Email == customerModel.Email).SingleOrDefault();
            if (customer != null)
            {
                customer.Address = customerModel.Address;
                customer.Landmark = customerModel.Landmark;
                customer.PhoneNumber = customerModel.PhoneNumber;
                customer.Pincode = customerModel.Pincode;
                customer.Name = customerModel.Name;
                customer.Locality = customerModel.Locality;
                customer.City = customerModel.City;
                customer.TypeOfLocation = customerModel.TypeOfLocation;
                return await this.user.SaveChangesAsync();
            }
            else
                return 0;
        }
        public List<CustomerModels> GetCustomerDetails(string email)
        {
            var cust = this.user.Customers.Where(op => op.Email == email).SingleOrDefault();
            if (cust != null)
            {
                return this.user.Customers.Where(op => op.Email == email).ToList();
            }
            return null;
        }
    }
}
