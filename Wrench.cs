using System;

public class Wrench: Tool
{
    public Wrench(int weight, bool inUse = true) : base("wrench", weight, inUse) { }

    public override void Describe()
    {
        Console.WriteLine($"this is a {this._name}. its weight is {this._weight}. Used to turn nuts and bolts.");
    }

    public override void Use()
    {
        Console.WriteLine($"the tool in use: {this._inUse}");
    }
}