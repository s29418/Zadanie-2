namespace Zadanie_2;
public class Program
{
    public static void Main(string[] args)
    {
        //Liquid Container
        Container container = new LiquidContainer(2000,20000, 2000, 6000);
        Container container2 = new LiquidContainer(2000,20000, 2000, 6000);
        try
        {
            container2.Load(10001, new Liquid("Fuel", true));
            container.Load(19000, new Liquid("Water", false));
            container.Load(3900, new Liquid("Water", false));
        }
        catch (OverfillException e)
        {
            Console.WriteLine(e.Message);
        }
        container2.Clear();
        Console.WriteLine(container);  
        Console.WriteLine(container2);

            
        //Gas Container
        Container container3 = new GasContainer(2000,20000, 2000, 6000,1);
        container3.Load(10000, new Gas("Chlorine"));
        container3.Clear();
        Console.WriteLine("\n" + container3);
        container3.Load(5000, new Gas("Nitrogen"));
        Console.WriteLine(container3 + "\n");
        
        
        //Cooling Container
        CoolingContainer container4 = new CoolingContainer(2000,20000, 2000, 6000, 10);
        Console.WriteLine(container4.ContainerSafeProducts());
        container4.Load(10000, new CoolingProduct("Fish"));
        container4.Load(10000, new Gas("Fuel"));
        container4.Load(10000, new CoolingProduct("Meat"));
        container4.Load(10000, new CoolingProduct("Fish"));
        Console.WriteLine(container4 + "\n");
        
        
        //Container Ship
        ContainerShip ship = new ContainerShip(15, 20, 30);
        ContainerShip ship2 = new ContainerShip(15, 20, 30);
        List<Container> containers = new List<Container>();
        containers.Add(container);
        containers.Add(container2);
        containers.Add(container3);
        try
        {
            ship.LoadContainers(containers);
        }
        catch (OverfillException e)
        {
            Console.WriteLine(e.Message);
        }
        ship2.LoadContainer(container3);
        ship2.LoadContainer(container4);
        Console.WriteLine(ship);
        Console.WriteLine("\n" + ship2);
        
        ship.UnloadShip();
        ship2.UnloadContainer(container3);
        ship2.ReplaceWithAnotherContainer("KON-C-4",container3);
        Console.WriteLine("\n" + ship2);
        Console.WriteLine(ship);
        
        ship2.MoveContainerToAnotherShip(ship, container3);
        Console.WriteLine("\n" + ship2);
        Console.WriteLine(ship);
    }
}