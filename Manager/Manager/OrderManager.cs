using Manager.IManager;
using Model.Orders;
using Repository.IRepository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    public class OrderManager : IOrdreManager
    {
        private readonly IOrderRepository orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public async Task<int> AddOrder(List<Orders> orderModels)
        {
            return await this.orderRepository.AddOrder(orderModels);
        }

        public IEnumerable GetOrders(string email)
        {
            return this.orderRepository.GetOrders(email);
        }
    }
}
