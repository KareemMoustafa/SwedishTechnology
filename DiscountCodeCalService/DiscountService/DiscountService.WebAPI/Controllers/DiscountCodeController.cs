using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiscountService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountCodeController : ControllerBase
    {
        
        // GET api/<DiscountCodeController>/5
        [HttpPost("{ServiceId}{CustomerID}")]
        public async Task<IActionResult> CalcDiscountCode(int ServiceId,string CustomerID)
        {

            var factory = new ConnectionFactory
            {
                HostName = "http://localhost:15672/"
            };
            //Create the RabbitMQ connection using connection factory details as i mentioned above
            var connection = factory.CreateConnection();
            //Here we create channel with session and model
            using
            var channel = connection.CreateModel();
            //declare the queue after mentioning name and a few property related to that
            channel.QueueDeclare("DiscountCode", exclusive: false);
            //Set Event object which listen message from chanel which is sent by producer
            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, eventArgs) => {
                var body = eventArgs.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
            };
            //read the message
            channel.BasicConsume(queue: "DiscountCode", autoAck: true, consumer: consumer);
            return Ok(await Task.Run(() => consumer));   
        }

    }
}
