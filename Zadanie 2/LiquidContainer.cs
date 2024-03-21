namespace Zadanie_2;

public class LiquidContainer : Container
{
    public LiquidContainer(double containerWeight, double maxCapacity, double height, double depth) : base(containerWeight, maxCapacity, height, depth)
    {
        this.serialNumber = "KON-L-" + id;
    }
}