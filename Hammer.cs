using System;

public class Hammer: Tool
{
    public Hammer(int weight, bool inUse = true):base("Hammer", weight, inUse) { }

    public override void Describe()
    {
        Console.WriteLine($"this is a {this._name}");
    }

    public override void Use()
    {
        Console.WriteLine($"the tool in use: {this._inUse}");
    }
}