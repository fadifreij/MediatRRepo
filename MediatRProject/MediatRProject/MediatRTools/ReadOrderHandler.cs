using MediatR;
using ServicesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRProject.MediatRTools
{
    public class ReadOrderHandler : IRequestHandler<ReadOrderCommand, IEnumerable<Order>>
    {
       
        private readonly IOrderRepository orderRepository;

        public ReadOrderHandler(IOrderRepository orderRepository)
        {
          
            this.orderRepository = orderRepository;
        }
        public async Task<IEnumerable<Order>> Handle(ReadOrderCommand request, CancellationToken cancellationToken)
        {
            var x = orderRepository.GetOrders();
            return await Task.FromResult(x);
        }
    }
}
