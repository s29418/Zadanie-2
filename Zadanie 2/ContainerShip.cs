namespace Zadanie_2;

public class ContainerShip
{
    public static int id = 0;
    public string serialNumber;
    protected List<Container> Containers;
    protected double maxSpeed;
    protected double maxContainers;
    protected double maxCapacity;
    protected double currentLoadWeight;

    public ContainerShip(double maxSpeed, double maxContainers, double maxCapacity)
    {
        id++;
        this.serialNumber = "Container Ship " + id;
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
        if ((this.currentLoadWeight + container.loadWeight + container.containerWeight) > maxCapacity * 1000)
        {
            throw new OverfillException();
        }
        this.currentLoadWeight += container.loadWeight;
        this.currentLoadWeight += container.containerWeight;
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

    public void ReplaceWithAnotherContainer(string serialNumber, Container container)
    {
        foreach (Container containerToReplace in Containers)
        {
            if (containerToReplace.serialNumber == serialNumber)
            {
                Containers.Remove(containerToReplace);
                this.currentLoadWeight -= containerToReplace.loadWeight;
                LoadContainer(container);
            }
            else
            {
                Console.WriteLine("Container not found on the ship");
            }
        }
    }

    public void MoveContainerToAnotherShip(ContainerShip anotherShip, Container container)
    {
        if (this.Containers.Contains(container))
        {
            this.UnloadContainer(container);
            anotherShip.LoadContainer(container);
        }
        else
        {
            Console.WriteLine("Container not found on the ship");
        }
    }

    public override string ToString()
    {
        string result = serialNumber + ": Max speed: " + maxSpeed + "kn, Max containers: " + maxContainers + ", Max capacity: " + maxCapacity + "Ton, Current load weight: " + currentLoadWeight + "kg";
        result += "\nContainers on ship:";
        foreach (Container container in Containers)
        {
            result += "\n" + container;
        }
        return result;
    }
}