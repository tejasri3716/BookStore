using Manager.IManager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Model.CartModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Route("api/[Controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartManager cartManager;

        public CartController(ICartManager cartManager)
        {
            this.cartManager = cartManager;
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart([FromBody]CartModels cartModels)
        {
            if (ModelState.IsValid)
            {
                var result = await this.cartManager.AddtoCart(cartModels);
                if (result != 0)
                {
                    return Ok(new { result });
                }
                return BadRequest("Error While Creating Object");
            }
            return BadRequest();
        }

        [HttpDelete]
        ///[Route("{id}")]
        public async Task<IActionResult> DeleteFromCart(int id)
        {
            if (ModelState.IsValid)
            {
                var result = await this.cartManager.DeleteFromCart(id);
                if (result != 0)
                {
                    return Ok(new { result });
                }
            }
            return BadRequest();
        }

        [HttpGet]
        public IActionResult GetAllBooks(string email)
        {
            var result = this.cartManager.GetAllBooks(email);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBook([FromBody]List<CartModels> cartModels)
        {
            var result = await this.cartManager.UpdateBook(cartModels);
            if(result!=0)
            {
                return Ok(new { result });
            }
            return BadRequest();
        }
    }
}
