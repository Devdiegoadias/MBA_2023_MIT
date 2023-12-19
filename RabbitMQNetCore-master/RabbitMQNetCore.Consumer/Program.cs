using RabbitMQNetCore.Consumer;

var consumer = new Consumer();

consumer.Consume();

Console.WriteLine(" Press [enter] to exit.");
Console.ReadLine();