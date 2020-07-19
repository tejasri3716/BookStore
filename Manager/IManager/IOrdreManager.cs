using Model.Orders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.IManager
{
    public interface IOrdreManager
    {
        Task<int> AddOrder(List<Orders> orderModels);
        IEnumerable GetOrders(string email);
    }
}
