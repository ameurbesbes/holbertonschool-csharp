using System;
using System.Reflection;

class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">Object to use</param>
    public static void Print(object myObj)
    {
        PropertyInfo[] p = myObj.GetType().GetProperties();
        MethodInfo [] m = myObj.GetType().GetMethods();

        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach(var property in p)
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine($"{myObj.GetType().Name} Methods:");
        foreach (var method in m) 
        {
            Console.WriteLine(method.Name); 
        }
    }
}
