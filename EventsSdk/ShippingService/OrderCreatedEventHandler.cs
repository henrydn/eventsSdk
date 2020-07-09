using Ats.Core.Events;
using MassTransit;
using OrderService;
using System;
using System.Threading.Tasks;

namespace ShippingService
{
    public class OrderCreatedEventHandler : IEventHandler<OrderCreatedEvent>
    {
        public Task Consume(ConsumeContext<OrderCreatedEvent> context)
        {
            var @event = context.Message;

            Console.WriteLine("*Order Created*");
            Console.WriteLine($" Address: {@event.Address}");
            Console.WriteLine($" Items: {string.Join(", ", @event.Items)}");
            Console.WriteLine();

            return Task.CompletedTask;
        }
    }
}
