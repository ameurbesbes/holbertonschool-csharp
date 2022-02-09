using System;
using System.Collections.Generic;

namespace _4_queue_enqueue_dequeue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> aQueue = new Queue<string>();

            aQueue.Enqueue("C");
            aQueue.Enqueue("HTML");
            aQueue.Enqueue("Javascript");
            aQueue.Enqueue("Python");
            aQueue.Enqueue("React");
            aQueue.Enqueue("Ruby");

            foreach (string item in aQueue)
                Console.WriteLine(item);

            Console.WriteLine("------");

            MyQueue.Info(aQueue, "C#", "Javascript");

            Console.WriteLine("------");

            foreach (string item in aQueue)
                Console.WriteLine(item);
        }
    }
}
