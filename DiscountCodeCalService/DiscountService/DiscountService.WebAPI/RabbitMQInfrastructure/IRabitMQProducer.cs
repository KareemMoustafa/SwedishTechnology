namespace DiscountService.WebAPI.RabbitMQInfrastructure
{
    public interface IRabitMQProducer
    {
        public void SendProductMessage<T>(T message);
    }
}
