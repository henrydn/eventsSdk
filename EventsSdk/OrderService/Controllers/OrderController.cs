using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("/api/orders")]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        public async Task CreateOrder()
        {
            Console.WriteLine("Order Created");
        }
    }
}
