namespace Zadanie_2;

public abstract class Product
{
    public string name;

    public Product(string name)
    {
        this.name = name;
    }

    public bool Equals(Product? product)
    {
        return this.name == product.name;
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

public class CoolingProduct : Product
{

    public CoolingProduct(string name) : base(name)
    {
    }

    public static Dictionary<string, double> MinTemperature = new Dictionary<string, double>()
    {
        {"Bananas", 13.3},
        {"Chocolate", 18},
        {"Fish", 2},
        {"Meat", -15},
        {"Ice cream", -18},
        {"Frozen pizza", -30},
        {"Cheese", 7.2},
        {"Sausages", 5},
        {"Butter", 20.5},
        {"Eggs", 19}
    };
}