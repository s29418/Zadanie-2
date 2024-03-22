namespace Zadanie_2;

public class Container
{
    public List<Product> Cargo = new List<Product>();
    public static int id = 0;
    public string serialNumber;
    public double containerWeight;
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


    public virtual void Clear()
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

    public override string ToString()
    {
        return "Container[" + serialNumber + "]: Container weight: " + containerWeight + "kg, Max capacity: " + maxCapacity + "kg, loadWeight: " + loadWeight + "kg, Height: " + height + "cm, Depth: " + depth + "cm";
    }
}