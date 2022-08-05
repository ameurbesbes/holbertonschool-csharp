using System;
/// <summary>Base class containing name and string override.</summary>
public abstract class Base{
	/// <summary>Name of the object.</summary>
	public string name;
	/// <summary>String override.</summary>
	public override string ToString() => $"{this.name} is a {this.GetType()}";
}