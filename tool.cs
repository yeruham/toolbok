using System;

public class Tool
{
    private string _name;
    private string _weight;

    public void Describe()
    {
        Console.WriteLine("this is tool");
    }

    public void Use()
    {
        Console.WriteLine("Tool is being used.");
    }
}