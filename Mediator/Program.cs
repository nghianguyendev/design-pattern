using MediatorPattern;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Threading.Tasks;

namespace MediatorUsingMediatR
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello Mediator design pattern!");

            var serviceProvider = new ServiceCollection()
                .AddMediatR(new[] { typeof(PingCommand).Assembly })
                .BuildServiceProvider();

            var mediator = serviceProvider.GetService<MediatR.IMediator>();
            var response = await mediator.Send(new PingCommand());
            Console.WriteLine($"We got a pong at {response.Timestamp}");
            Console.ReadKey();
        }

        //static async Task Main(string[] args)
        //{
        //    Console.WriteLine("Hello Mediator design pattern!");
        //    var mediator = new SampleMediator();
        //    var devTeam = new DevTeam(mediator);
        //    var customer = new Customer();
        //    mediator.Customer = customer;
        //    var answer = devTeam.AskQuestion("A question");
        //    Console.WriteLine(answer);
        //    Console.ReadKey();
        //}
    }
}
