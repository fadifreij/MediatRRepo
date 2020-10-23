using ServicesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRProject
{
    public class DBContext
    {
        private readonly List<Order> list;
        public DBContext()
        {
            list = new List<Order>
            {
                new Order { Id = 1 , OrderName = "Order1" , Qty=3},
                new Order {Id = 2 , OrderName = "Order2" , Qty=2}
            };
        }

        public List<Order> GetList() => list;
    }
}
