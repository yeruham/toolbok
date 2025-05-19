using System;

public class PipeCutter: Tool
{
    public PipeCutter(int weight, bool inUse = true) : base("PipeCutter", weight, inUse) { }

    public override void Describe()
    {
        Console.WriteLine($"this is a {this._name}. its weight is {this._weight}. Used to cut pipes.");
    }

    public override void Use()
    {
        Console.WriteLine($"the tool in use: {this._inUse}");
    }
}