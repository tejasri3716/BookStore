using Model.Orders;
using Repository.Context;
using Repository.IRepository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryClasses
{
    public class OrderRepository : IOrderRepository
    {
        private readonly UserContext userContext;
        private readonly ICartRepo cartRepo;

        public OrderRepository(UserContext userContext,ICartRepo cartRepo)
        {
            this.userContext = userContext;
            this.cartRepo = cartRepo;
        }
        public async Task<int> AddOrder(List<Orders> orderModels)
        {
            var order = new TotalOrders();
            order.Email = orderModels[0].Email;
            await this.userContext.AllOrders.AddAsync(order);
            await this.userContext.SaveChangesAsync();
            var rows = 0;
            order = this.userContext.AllOrders.LastOrDefault();
            foreach (var item in orderModels)
            {
                item.OrderId = order.OrderId;
                await this.userContext.Orders.AddAsync(item);
                rows = await this.userContext.SaveChangesAsync();
                var book = await this.userContext.Books.FindAsync(item.BookId);
                var previousBook = book;
                if(book.NoOfBooks>=item.Quantity && book.NoOfBooks>0)
                {
                    book.NoOfBooks = book.NoOfBooks - item.Quantity;
                    this.userContext.Entry(previousBook).CurrentValues.SetValues(book);
                    await this.userContext.SaveChangesAsync();
                }               
                await this.cartRepo.DeleteFromCart(item.BookId);
            }
            return rows;
        }

        public IEnumerable GetOrders(string email)
        {
            var result = (from book in this.userContext.Books
                          join orders in this.userContext.Orders.Where(op => op.Email.Equals(email))
                          on book.BookId equals orders.BookId
                          orderby book.BookId
                          select new
                          {
                              orders.OrderId,
                              orders.BookId,
                              orders.Quantity,
                              book.BookImage,
                              book.Author,
                              book.BookPrice,
                              book.BookTitle
                          }).ToList();
            return result;
        }
    }
}
