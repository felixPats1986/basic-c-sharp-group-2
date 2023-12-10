namespace Assignment4;

public class Car : IVehicle
{
    public int carFuel;

    public Car(int carFuel)
    {
        this.carFuel = carFuel;
    }
    
    public void Drive()
    {
        if (carFuel > 0)
        {
            Console.WriteLine("Car is driving");
        }
        else
        {
            Console.WriteLine("Car needs fuel");
        }
        
    }

    public bool Refuel(int gasAmount)
    {
        carFuel += gasAmount;
        return true;
    }
}