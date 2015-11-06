using System;

namespace Task3.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<int> queue = new CustomQueue<int>(9);
            queue.Enqueue(4);
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue(0);
            queue.Enqueue(-1);

            foreach (var a in queue)
                Console.WriteLine(a);
            Console.WriteLine("---------------");

            Console.WriteLine("Peek = {0}",queue.Peek());
            Console.WriteLine("---------------");

            Console.WriteLine("Dequeue = {0}", queue.Dequeue());
            Console.WriteLine("Dequeue = {0}", queue.Dequeue());
            Console.WriteLine("Dequeue = {0}", queue.Dequeue());
            Console.WriteLine("---------------");

            foreach (var a in queue)
                Console.WriteLine(a);
        
        }
    }
}
