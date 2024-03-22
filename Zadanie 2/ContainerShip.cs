namespace Zadanie_2;

public class ContainerShip
{
    protected List<Container> Containers;
    protected double maxSpeed;
    protected double maxContainers;
    protected double maxCapacity;
    protected double currentLoadWeight;

    public ContainerShip(List<Container> containers, double maxSpeed, double maxContainers, double maxCapacity)
    {
        this.Containers = new List<Container>();
        this.maxSpeed = maxSpeed;
        this.maxContainers = maxContainers;
        this.maxCapacity = maxCapacity;
        this.currentLoadWeight = 0;
    }
    
    public void LoadContainer(Container container)
    {
        if (this.Containers.Count + 1 > maxContainers)
        {
            Console.WriteLine("There are too many containers on the ship");
            return;
        }
        if (this.currentLoadWeight + container.loadWeight > maxCapacity)
        {
            throw new OverfillException();
        }
        this.currentLoadWeight += container.loadWeight;
        this.Containers.Add(container);
    }
    
    public void LoadContainers(List<Container> containers)
    {
        foreach (Container container in containers)
        {
            LoadContainer(container);
        }
    }

    public void UnloadContainer(Container container)
    {
        if (this.Containers.Contains(container))
        {
            this.Containers.Remove(container);
            this.currentLoadWeight -= container.loadWeight;
        }
        else
        {
            Console.WriteLine("Container not found on the ship");
        }
    }
    
    public void UnloadShip()
    {
        this.Containers.Clear();
        this.currentLoadWeight = 0;
    }
    
    
}