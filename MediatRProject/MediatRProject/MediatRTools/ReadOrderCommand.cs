using MediatR;
using ServicesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRProject.MediatRTools
{
    public class ReadOrderCommand : IRequest<IEnumerable<Order>>
    {
    }
}
