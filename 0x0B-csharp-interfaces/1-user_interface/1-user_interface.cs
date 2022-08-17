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
/// Test class for interfaces
/// </summary>
public class TestObject: Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Interact()
    /// </summary>
    public void Interact(){}
    /// <summary>
    /// int durability
    /// </summary>
    public int durability { get; set; }
    /// <summary>
    /// Break()
    /// </summary>
    public void Break(){}
    /// <summary>
    /// Collect()
    /// </summary>
    public void Collect(){}
    /// <summary>
    /// bool isCollected
    /// </summary>
    public bool isCollected { get; set;}
}