using System;
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
        Console.WriteLine($"You try to open the {name}. It's locked");
    }

}
