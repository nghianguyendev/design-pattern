using System;
using System.Linq;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Adapter Design Pattern!");

            var messageProvider = new MessageProvider();
            var messages = messageProvider.GetMessages();
            Console.WriteLine(messages.FirstOrDefault());
        }
    }
}
