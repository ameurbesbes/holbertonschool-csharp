using System;

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

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// Test class for interfaces
/// </summary>
public class TestObject: Base, IInteractive, IBreakable, ICollectable
{
    public void Interact(){}
    public int durability { get; set; }
    public void Break(){}
    public void Collect(){}
    public bool isCollected { get; set;}
}