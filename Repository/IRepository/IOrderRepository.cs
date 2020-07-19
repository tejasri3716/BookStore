using Model.Orders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IOrderRepository
    {
        Task<int> AddOrder(List<Orders> orderModels);
        IEnumerable GetOrders(string email);
    }
}
