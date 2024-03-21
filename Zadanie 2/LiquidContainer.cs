namespace Zadanie_2;

public class LiquidContainer : Container
{
    public LiquidContainer(double containerWeight, double maxCapacity, double height, double depth) : base(
        containerWeight, maxCapacity, height, depth)
    {
        this.serialNumber = "KON-L-" + id;
    }

    public override void Load(double loadWeight, Product liquid)
    {
        if (Cargo.Count == 0 || Cargo[0].name == liquid.name)
        {
            if (liquid.GetType().Equals(typeof(Liquid)))
            {
                Liquid liquidProduct = (Liquid)liquid;
                double maxLoad = liquidProduct.isHazard ? maxCapacity * 0.5 : maxCapacity * 0.9;
            
                if (this.loadWeight + loadWeight > maxCapacity)
                {
                    throw new OverfillException();
                }else if(this.loadWeight + loadWeight > maxLoad)
                {
                    SendHazardNotification("Recommended load weight in the container has been exceeded. Recommended load weight is " + maxLoad, this.serialNumber);
                    this.loadWeight += loadWeight;
                    this.Cargo.Add(liquidProduct);
                }
                else
                {
                    this.loadWeight += loadWeight;
                    this.Cargo.Add(liquidProduct);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid product type");
        }
    }
    
    public void SendHazardNotification(string message, string containerNumber)
    {
        Console.WriteLine($"Hazard Notification for Container {containerNumber}: {message}");
    }
}