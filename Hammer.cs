using System;

public class Hammer: Tool
{
    public Hammer(int weight, bool inUse = true):base("Hammer", weight, inUse) { }

    public override void Describe()
    {
        Console.WriteLine($"this is a {this._name}. its weight is {this._weight}. Used to hit or drive nails");
    }

    public override void Use()
    {
        Console.WriteLine($"the tool in use: {this._inUse}");
    }
}