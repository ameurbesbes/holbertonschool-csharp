using System;
using System.Collections.Generic;
using System.Linq;

class MyQueue
{
	public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count()}");
        if(aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }
        aQueue.Enqueue(newItem);
        Console.WriteLine($"Queue contains \"{search}\": {aQueue.Contains(search)}");
        while (aQueue.Contains(search))
        {
            aQueue.Dequeue();
        }
        return aQueue;
    }
}