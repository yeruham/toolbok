using System;

public class Screwdriver: Tool
{
    public Screwdriver(int weight, bool inUse = true) : base("Screwdriver", weight, inUse) { }

    public override void Describe()
    {
        Console.WriteLine($"this is a {this._name}");
    }

    public override void Use()
    {
        Console.WriteLine($"the tool in use: {this._inUse}");
    }
}