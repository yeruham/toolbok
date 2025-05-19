using System;

public class Saw : Tool
{
    public Saw(int weight, bool inUse = true) : base("Saw", weight, inUse) { }

    public override void Describe()
    {
        Console.WriteLine($"this is a {this._name}. its weight is {this._weight}. Used to cut wood or metal.");
    }

    public override void Use()
    {
        Console.WriteLine($"the tool in use: {this._inUse}");
    }
}