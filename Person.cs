class Person
{
    public const string TYPE = "Person";
    public string Name = "Undefined";
    public int Age = 0;

    public void Print()
    {
        Console.WriteLine($"Type: {TYPE}\nName: {Name}\nAge: {Age}");
    }
}
