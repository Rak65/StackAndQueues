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
            queue.Queue(56);
            queue.Queue(30);
            queue.Queue(70);
            queue.Display();

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Display();
            Console .ReadKey();
        }
    }
}
