using System;
using RabbitMQ.Client;
using System.Text;
using System.Threading;

namespace Sender
{
    public class Publisher  
    {

        public static readonly string QueueName = "teste";

        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: QueueName,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);


                var j = 0;
                while(j < 4){

                    var message = $"Mensagem {j}!";
                    var body = Encoding.UTF8.GetBytes(message);
                    
                    channel.BasicPublish(exchange: "",
                                        routingKey: QueueName,
                                        basicProperties: null,
                                        body: body);
                    j++;
                    Console.WriteLine(" enviado {0}", message);
    
                    Thread.Sleep(1000);
                }
            }

            Console.WriteLine(" ...");
            Console.ReadLine();
        }
    }
}
