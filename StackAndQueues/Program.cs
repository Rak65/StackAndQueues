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
            Console.WriteLine("Create a Stack.");
            LinkedList stack = new LinkedList();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Display();
            Console .ReadKey();
        }
    }
}
