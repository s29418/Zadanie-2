namespace Zadanie_2;

public class Container
{
    public List<Product> Cargo = new List<Product>();
    public static int id = 0;
    public string serialNumber;
    private double containerWeight;
    public double loadWeight;
    protected double maxCapacity;
    private double height;
    private double depth;

    public Container(double containerWeight, double maxCapacity, double height, double depth)
    {
        id++;
        this.containerWeight = containerWeight;
        this.maxCapacity = maxCapacity;
        this.height = height;
        this.depth = depth;
        this.loadWeight = 0;
        this.Cargo = new List<Product>();
    }


    public void Clear()
    {
        this.loadWeight = 0;
        this.Cargo.Clear();
    }

    public virtual void Load(double loadWeight, Product product)
    {
        if (this.loadWeight + loadWeight > maxCapacity)
        {
            throw new OverfillException();
        }
        this.loadWeight += loadWeight;
        this.Cargo.Add(product);
    }
}