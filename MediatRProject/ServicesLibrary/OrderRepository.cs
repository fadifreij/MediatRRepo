using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServicesLibrary
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> _list;

        public OrderRepository(List<Order> list)
        {
            _list = list;
        }
        public async Task<Order> AddOrder(Order order)
        {
            _list.Add(order);
            return await Task.FromResult(order);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _list;
        }
    }
}
