using System;
using System.Threading.Tasks;
using Ats.Core.Events;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("/api/orders")]
    public class OrderController : ControllerBase
    {
        private readonly IEventService _eventService;

        public OrderController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpPost]
        public async Task CreateOrder()
        {
            Console.WriteLine("Order Created");

            await _eventService.Publish(new OrderCreatedEvent() { 
                Address = "221B Baker street, London",
                Items = new[] 
                { 
                    "Smoking pipe", 
                    "Deerstalker hat", 
                    "Magnifying glass" 
                }
            });
        }
    }
}
