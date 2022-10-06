using System;
using System.Collections.Generic;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONStorage storage = new JSONStorage();
            storage.Load();
        }
    }
}