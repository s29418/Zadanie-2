namespace Zadanie_2;
    public class Program
    {
        public static void Main(string[] args)
        {
            Container container = new LiquidContainer(20.0,2000, 20.0, 20.0);
            Container container2 = new LiquidContainer(20.0,2000, 20.0, 20.0);
            Console.WriteLine(container.serialNumber);
            Console.WriteLine(container2.serialNumber);
            
            
            container2.Load(1200, new Liquid("Fuel", true));
            container.Load(1960, new Liquid("Water", false));
            container.Load(39, new Liquid("Water", false));
            Console.WriteLine(container.loadWeight);
            Console.WriteLine(container2.loadWeight);
            for(int i = 0; i < container.Cargo.Count; i++)
            {
                Console.WriteLine(container.Cargo[i].name);
            }
        }
    }

