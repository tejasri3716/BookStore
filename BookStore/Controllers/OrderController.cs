using Manager.IManager;
using Microsoft.AspNetCore.Mvc;
using Model.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Route("api/[Controller]")]
    public class OrderController :ControllerBase
    {
        private readonly IOrdreManager orderManager;

        public OrderController(IOrdreManager orderManager)
        {
            this.orderManager = orderManager;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder([FromBody]List<Orders> orders)
        {
           if(ModelState.IsValid)
            {
                var result = await this.orderManager.AddOrder(orders);
                if (result != 0)
                {
                    return Ok(new { result });
                }
            }
            return BadRequest();
        }

        [HttpGet]
        public IActionResult GetOrders(string email)
        {
            if(ModelState.IsValid)
            {
                var result = this.orderManager.GetOrders(email);
                if(result!=null)
                {
                    return Ok(result);
                }
            }
            return BadRequest();
        }

    }
}
