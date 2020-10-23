using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLibrary
{
    public  interface IOrderRepository
    {
       Task<Order> AddOrder(Order order);
        IEnumerable<Order> GetOrders();
    }
}
