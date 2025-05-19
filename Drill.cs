using System;

public class Drill : Tool
{
    public Drill(int weight, bool inUse = true) : base("Drill", weight, inUse) { }

    public override void Describe()
    {
        Console.WriteLine($"this is a {this._name}");
    }

    public override void Use()
    {
        Console.WriteLine($"the tool in use: {this._inUse}");
    }
}