namespace Zadanie_2;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double containerWeight, double maxCapacity, double height, double depth) : base(containerWeight, maxCapacity, height, depth)
    {
        this.serialNumber = "KON-G-" + id;
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