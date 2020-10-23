using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRProject.MediatRTools;
using Microsoft.AspNetCore.Mvc;
using ServicesLibrary;

namespace MediatRProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly IMediator mediator;

        public OrderController(
            IMediator mediator
            )
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(mediator.Send(new ReadOrderCommand()));
        }
        [HttpPost]
        public IActionResult Add(Order order)
        {
            return Ok(mediator.Send(new CreateOrderCommand { Order = order }));
        }
    }
}
