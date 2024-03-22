namespace Zadanie_2;

public class GasContainer : Container, IHazardNotifier
{
    public double pressure;
    public GasContainer(double containerWeight, double maxCapacity, double height, double depth, double pressure) : base(containerWeight, maxCapacity, height, depth)
    {
        this.serialNumber = "KON-G-" + id;
        this.pressure = pressure;
    }

    public override void Load(double loadWeight, Product gas)
    {
        if (Cargo.Count != 0 && Cargo[0].name != gas.name)
        {
            SendHazardNotification("Gas container should not contain more than one type of gas", this.serialNumber);
        }
        base.Load(loadWeight, gas);
    }

    public override void Clear()
    {
        this.loadWeight = loadWeight * 0.05;
    }
    
    public void SendHazardNotification(string message, string containerNumber)
    {
        Console.WriteLine($"Hazard Notification for Container {containerNumber}: {message}");
    }
}