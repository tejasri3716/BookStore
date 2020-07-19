using Manager.IManager;
using Microsoft.AspNetCore.Mvc;
using Model.WishList;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Route("api/[Controller]")]
    public class WishListController : ControllerBase
    {
        private readonly IWishListManager wish;

        public WishListController(IWishListManager wish)
        {
            this.wish = wish;
        }
        [HttpPost]
        public async Task<IActionResult> AddToWishList([FromBody] WishListModel wishListModel)
        {
            if (ModelState.IsValid)
            {
                var res = await this.wish.AddToWishList(wishListModel);
                if (res != 0)
                {
                    return Ok(new { res });
                }
                return BadRequest(new { Error = "Error occured while adding to wishlist" });
            }
            return BadRequest(new { Error = "Error in object" });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFromWishList(int id)
        {
            if (ModelState.IsValid)
            {
                var res = await this.wish.DeleteFromWishList(id);
                if (res != 0)
                {
                    return Ok(new { res });
                }
                return BadRequest(new { Error = "Error occured while deleting from wishlist" });
            }
            return BadRequest(new { Error = "Invalid id" });
        }

        [HttpGet]
        public IActionResult GetAllBooks(string email)
        {
            if (ModelState.IsValid)
            {
                var res = this.wish.GetAllBooks(email);
                if (res != null)
                {
                    return Ok(res);
                }
                return BadRequest(new { Error = "Invalid Result" });
            }
            return BadRequest(new { Error = "Invalid Email" });
        }

    }
}
