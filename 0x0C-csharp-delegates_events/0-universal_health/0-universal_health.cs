using System;
/// <summary>
/// class player 
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    /// <summary>
    /// constructor for the player class
    /// </summary>
    /// <param name="name"> the name of the player</param>
    /// <param name="maxHp"> the max hp of the player</param>
    public Player(string name = "Player", float maxHp=100f)
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        
        this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }
    /// <summary>
    /// display the hp of the playeer
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health=100f");
    }
}