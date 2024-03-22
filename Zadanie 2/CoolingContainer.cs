namespace Zadanie_2;

public class CoolingContainer : Container
{
    public double ContainerTemperature;

    public CoolingContainer(double containerWeight, double maxCapacity, double height, double depth, double containerTemperature) : base(containerWeight, maxCapacity, height, depth)
    {
        this.ContainerTemperature = containerTemperature;
        this.serialNumber = "KON-C-" + id;
    }
    
    public override void Load(double loadWeight, Product product)
    {
        if (product is CoolingProduct)
        {
            if (Cargo.Count != 0 && Cargo[0].name != product.name)
            {
                Console.WriteLine("Container should not contain more than one type of cooling product");
                return;
            }
            else if (CoolingProduct.MinTemperature[product.name] > ContainerTemperature)
            {
                Console.WriteLine("Product cannot be loaded, temperature too high");
                return;
            }
        }
        else
        {
            Console.WriteLine("Product is not a cooling product");
            return;
        }
        base.Load(loadWeight, product);
    }

    public override string ToString()
    {
        return base.ToString() + ", Container temperature: " + ContainerTemperature + "C";
    }
}