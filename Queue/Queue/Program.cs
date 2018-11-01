using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();

            queue.Enqueue(3);
            queue.Enqueue(6);
            queue.Enqueue(9);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            queue.Clear();

            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}
