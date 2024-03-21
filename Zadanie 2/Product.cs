namespace Zadanie_2;

public abstract class Product
{
    public string name;

    protected Product(string name)
    {
        this.name = name;
    }
}

public class Liquid : Product
{
    public Boolean isHazard;

    public Liquid(string name, Boolean isHazard) : base(name)
    {
        this.isHazard = isHazard;
    }
}

public class Gas : Product
{
    public Gas(string name) : base(name)
    {
    }
}