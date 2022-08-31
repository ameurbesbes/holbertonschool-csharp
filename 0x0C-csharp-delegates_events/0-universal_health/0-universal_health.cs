using System;

/// <summary>
/// Player: class
/// </summary>
public class Player
{
	/// <summary>
	/// name: property
	/// </summary>
	private string name;
	
	/// <summary>
	/// maxHp: property
	/// </summary>
	private float maxHp;
	
	/// <summary>
	/// hp: property
	/// </summary>
	private float hp;


	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="name">string</param>
	/// <param name="maxHp">float</param>
	public Player(string name = "Player", float maxHp = 100f)
    {
		this.name = name;
		if(maxHp <= 0)
        {
			this.maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
		else
			this.maxHp = maxHp;
		hp = this.maxHp;
    }

	/// <summary>
	/// PrintHealth: method that prints player's current health status
	/// </summary>
	public void PrintHealth()
    {
		Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}