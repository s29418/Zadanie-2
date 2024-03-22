namespace Zadanie_2;
public class Program
{
    public static void Main(string[] args)
    {
        Container container = new LiquidContainer(20.0,2000, 20.0, 20.0);
        Container container2 = new LiquidContainer(20.0,2000, 20.0, 20.0);
        Console.WriteLine(container.serialNumber);
        Console.WriteLine(container2.serialNumber);
            
            
        // container2.Load(1200, new Liquid("Fuel", true));
        // container.Load(1960, new Liquid("Water", false));
        // container.Load(39, new Liquid("Fuel", false));
        // Console.WriteLine(container.loadWeight);
        // Console.WriteLine(container2.loadWeight);
        // for(int i = 0; i < container.Cargo.Count; i++)
        // {
        //     Console.WriteLine(container.Cargo[i].name);
        // }
            
            
        // Container container3 = new GasContainer(20.0,2000, 20.0, 20.0,1);
        // container3.Load(1000, new Gas("Oxygen"));
        // container3.Clear();
        // Console.WriteLine(container3.loadWeight);
        // container3.Load(500, new Gas("Other"));
        // Console.WriteLine(container3.loadWeight);
        
        Container container4 = new CoolingContainer(20.0,2000, 20.0, 20.0, 10);
        container4.Load(1000, new CoolingProduct("Fish"));
        Console.WriteLine(container4.loadWeight);
        container4.Load(1000, new Gas("Fuel"));
        container4.Load(1000, new CoolingProduct("Meat"));
        container4.Load(1000, new CoolingProduct("Fish"));
        container4.Clear();
        for(int i = 0; i < container4.Cargo.Count; i++)
        {
            Console.WriteLine(container4.Cargo[i].name);
        }
        Console.WriteLine(container4.loadWeight);
        
        
    }
}