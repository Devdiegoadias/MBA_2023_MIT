using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQNetCore.Models;
using System.Text;

namespace RabbitMQNetCore.Publisher
{
    public class Publisher
    {
        public bool QueueMessage(Message message)
        {
            var retVal = false;

            try
            {
                var factory = new ConnectionFactory() { HostName = "localhost" };
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "myQueue", durable: false, exclusive: false, autoDelete: false, arguments: null);

                    var stringContent = JsonConvert.SerializeObject(message);
                    var body = Encoding.UTF8.GetBytes(stringContent);

                    channel.BasicPublish(exchange: "", routingKey: "myQueue", basicProperties: null, body: body);
                }

                retVal = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return retVal;
        }
    }
}
