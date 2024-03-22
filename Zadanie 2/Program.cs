namespace Zadanie_2;
public class Program
{
    public static void Main(string[] args)
    {
        Container container = new LiquidContainer(20.0,2000, 20.0, 20.0);
        Container container2 = new LiquidContainer(20.0,2000, 20.0, 20.0);
        Console.WriteLine(container.serialNumber);
        Console.WriteLine(container2.serialNumber);
        Console.WriteLine(container2);
            
            
        container2.Load(1000, new Liquid("Fuel", true));
        container.Load(1960, new Liquid("Water", false));
        container.Load(39, new Liquid("Fuel", false));
        Console.WriteLine(container.loadWeight);
        Console.WriteLine(container2.loadWeight);

            
            
        Container container3 = new GasContainer(20.0,2000, 20.0, 20.0,1);
        Console.WriteLine(container3);
        container3.Load(1000, new Gas("Oxygen"));
        container3.Clear();
        Console.WriteLine(container3.loadWeight);
        container3.Load(500, new Gas("Other"));
        Console.WriteLine(container3.loadWeight);
        
        Container container4 = new CoolingContainer(20.0,2000, 20.0, 20.0, 10);
        container4.Load(1000, new CoolingProduct("Fish"));
        Console.WriteLine(container4.loadWeight);
        container4.Load(1000, new Gas("Fuel"));
        container4.Load(1000, new CoolingProduct("Meat"));
        container4.Load(1000, new CoolingProduct("Fish"));
        container4.Clear();
        Console.WriteLine(container4);
        
        
        ContainerShip ship = new ContainerShip(15, 20, 5);
        ship.LoadContainer(container);
        ship.LoadContainer(container2);
        ship.LoadContainer(container3);
        ship.LoadContainer(container4);
        ship.LoadContainer(container2);
        Console.WriteLine(ship);
    }
}