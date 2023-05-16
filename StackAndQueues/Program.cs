using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Create a Queue");
            LinkedList queue = new LinkedList();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            Console .ReadKey();
        }
    }
}
