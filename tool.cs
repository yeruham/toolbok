using System;

public  class Tool
{
    protected string _name;
    protected int _weight;
    protected bool _inUse;

    public Tool(string name, int weight, bool inUse = true)
    {
        this._name = name;
        this._weight = weight;
        this._inUse = inUse;
    }

    public virtual void Describe()
    {
        Console.WriteLine("this is tool");
    }

    public virtual void Use()
    {
        Console.WriteLine("Tool is being used.");
    }
}