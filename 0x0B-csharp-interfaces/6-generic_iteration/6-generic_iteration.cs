using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
/// <summary>
/// obstract class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name of the object.
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// Overide ToString Method
    /// </summary>
    public override string ToString() => $"{this.name} is a {this.GetType()}";
}
/// <summary>
/// interface IIdentifiable
/// </summary>
interface IInteractive
{
    /// <summary>
    /// interact()
    /// </summary>
    void Interact();
}
/// <summary>
/// interface IBreakable
/// </summary>
interface IBreakable
{
    /// <summary>
    /// int
    /// </summary>
    int durability { get; set; }
    /// <summary>
    /// method Break()
    /// </summary>
    void Break();
}
/// <summary>
/// interface ICollectable
/// </summary>
interface ICollectable
{
    /// <summary>
    /// bool isCollected
    /// </summary>
    bool isCollected { get; set; }
    /// <summary>
    /// collect()
    /// </summary>
    void Collect();
}

/// <summary>
/// class Door
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// constructor
    /// </summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }
    /// <summary>
    /// interact()
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }

}
/// <summary>
/// Decoration Class
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    ///<summary>
    ///Gets and sets isQuestItem
    ///</summary>
    public bool isQuestItem { get; set; }
    /// <summary>
    /// int
    /// </summary>
    public int durability { get; set; }
    /// <summary>
    /// method Break()
    /// </summary>
    /// ///<summary>Decoration constructor</summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability < 1)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    ///<summary>
    ///Breaks decoration
    ///</summary>
    public void Break()
    {
        durability -= 1;
        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
    /// <summary>
    /// interact()
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }
}
/// <summary>
/// key class
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// bool isCollected
    /// </summary>
    public bool isCollected { get; set; }
    /// <summary>
    /// initialise a Key object
    /// </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// collect()
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}
/// <summary>
/// Objs enumerable
/// </summary>
public class Objs<T> : IEnumerable<T>
{
    private List<T> _items = new List<T>();
    ///<summary>
    ///Add method.
    ///</summary>
    public void Add(T item)
    {
        _items.Add(item);
    }
    /// <summary>
    /// Returns an enumerator that can be used to iterate through the collection.
    /// </summary>
    /// <returns></returns>
    public IEnumerator<T> GetEnumerator()
    {
        return _items.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}