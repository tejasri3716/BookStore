using Manager.IManager;
using Microsoft.AspNetCore.Mvc;
using Model.CustomerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Route("api/[Controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerManager customer;

        public CustomerController(ICustomerManager customer)
        {
            this.customer = customer;
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer([FromBody] CustomerModels customer)
        {
            if (ModelState.IsValid)
            {
                var result = await this.customer.AddCustomerDetails(customer);
                if (result != 0)
                {
                    return Ok(new { result });
                }
            }
            return BadRequest();
        }

        [HttpGet]
        public IActionResult GetCustomerDetails(string email)
        {
            if (ModelState.IsValid)
            {
                var result = this.customer.GetCustomerDetails(email);
                if (result != null)
                {
                    return Ok(result);
                }
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCustomerDetails(int id)
        {
            if (ModelState.IsValid)
            {
                var result = await this.customer.DeleteCustomerDetails(id);
                if (result != 0)
                {
                    return Ok(new { result });
                }
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomerDetails([FromBody] CustomerModels customer)
        {
            if (ModelState.IsValid)
            {
                var result = await this.customer.UpdateCustomerDetails(customer);
                if (result != 0)
                {
                    return Ok(new { result });
                }
            }
            return BadRequest();
        }
    }
}
