using System;

class Obj
{
    /// <summary>
    /// Checks if the object is a derived class
    /// </summary>
    /// <param name="derivedType">Drived object to be checked</param>
    /// <param name="baseType">Base Class</param>
    /// <returns>True if derived class, false otherwise</returns>
	public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType)) return true;
        else return false;
    }
}