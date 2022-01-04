using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
	    
		Console.WriteLine($"{str}{str}{str}");

		for (int i = 0; i < 9; i++)
		{
			Console.Write(str[i]);
		}
    }
}