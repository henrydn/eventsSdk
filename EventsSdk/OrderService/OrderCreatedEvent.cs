namespace OrderService
{
    public class OrderCreatedEvent
    {
        public string Address { get; set; }
        public string[] Items { get; set; }
    }
}
