using System;
using System.Collections.Generic;

/// <summary>Represents the class Obj.</summary>
class Obj
{
    /// <summary>
    /// check if obj insatnce of array or sub
    /// </summary>
    /// <param name="obj">obj to check</param>
    /// <returns> True or  False </returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj.GetType() == typeof(Array) || obj is Array;
    }

}
