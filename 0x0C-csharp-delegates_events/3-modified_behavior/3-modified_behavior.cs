﻿using System;

/// <summary>
/// enum modefier
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak
    /// </summary>
    Weak,
    /// <summary>
    /// Base
    /// </summary>
    Base,
    /// <summary>
    /// Strong
    /// </summary>
    Strong
};
/// <summary>
/// calculate modefier
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// class player 
/// </summary>
public class Player
{
    private String name;
    private float maxHp;
    private float hp;
    /// <summary>
    /// constructor for the player class
    /// </summary>
    /// <param name="name"> the name of the player</param>
    /// <param name="maxHp"> the max hp of the player</param>
    public Player(string name = "Player", float maxHp = 100f)
    {

        this.name = name;

        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;

        this.hp = maxHp;
    }
    /// <summary>
    /// apply a modefier on the player
    /// </summary>
    /// <param name="baseValue"> basevalue that modefier will be applied on</param>
    /// <param name="modifier">type of modefier</param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if(modifier == Modifier.Weak)
            return baseValue / 2;
        else if (modifier == Modifier.Strong)
            return baseValue * 1.5f;
        else
            return baseValue;
    }
    /// <summary>
    /// display the hp of the playeer
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
    /// <summary>
    ///  apply damage to player hp
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        hp -= damage;
        ValidateHP(hp);
    }
    /// <summary>
    /// heal damage of the player
    /// </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        hp += heal;
        ValidateHP(hp);
    }
    /// <summary>
    /// delegate 
    /// </summary>
    /// <param name="damage"></param>
    public delegate void CalculateHealth(float damage);
    /// <summary>
    /// validate hp and set the new value
    /// </summary>
    /// <param name="newHp"> new value of the hp to be set</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }

}