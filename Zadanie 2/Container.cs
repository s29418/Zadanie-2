namespace Zadanie_2;

public class Container
{
    public static int id = 0;
    public string serialNumber;
    private double containerWeight;
    public double loadWeight;
    private double maxCapacity;
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
    }


    public void Clear()
    {
        this.loadWeight = 0;
    }

    public void Load(double loadWeight)
    {
        if (this.loadWeight + loadWeight > maxCapacity)
        {
            throw new OverfillException();
        }
        this.loadWeight += loadWeight;
    }
}