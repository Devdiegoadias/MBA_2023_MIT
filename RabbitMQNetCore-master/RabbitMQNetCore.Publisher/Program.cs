using RabbitMQNetCore.Models;
using RabbitMQNetCore.Publisher;

var publisher = new Publisher();

while (true)
{
    Console.WriteLine("Enter the message you want to send");
    var content = Console.ReadLine();

    if (!string.IsNullOrEmpty(content))
        publisher.QueueMessage(new Message { Content = content });
}