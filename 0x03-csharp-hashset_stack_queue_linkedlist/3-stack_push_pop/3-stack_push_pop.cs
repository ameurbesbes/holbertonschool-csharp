using System;
using System.Collections.Generic;
using System.Linq;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        var numberofelem = aStack.Count();
        Console.WriteLine($"Number of items: {numberofelem}");
        if (numberofelem == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }
        bool containsearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {containsearch}");
        while (aStack.Contains(search))
        {
            aStack.Pop();
        }
        aStack.Push(newItem);
        return aStack;
    }
}