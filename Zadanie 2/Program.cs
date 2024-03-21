namespace Zadanie_2;
    public class Program
    {
        public static void Main(string[] args)
        {
            Container container = new LiquidContainer(20.0,2000, 20.0, 20.0);
            Container container2 = new LiquidContainer(20.0,2000, 20.0, 20.0);
            Console.WriteLine(container.serialNumber);
            Console.WriteLine(container2.serialNumber);
            Console.WriteLine(container2.loadWeight);
            
            Console.WriteLine("Hello World!");
        }
    }

