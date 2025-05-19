using System;

public class Saw : Tool
{
    public Saw(int weight, bool inUse = true) : base("Saw", weight, inUse) { }

    public override void Describe()
    {
        Console.WriteLine($"this is a {this._name}");
    }

    public override void Use()
    {
        Console.WriteLine($"the tool in use: {this._inUse}");
    }
}