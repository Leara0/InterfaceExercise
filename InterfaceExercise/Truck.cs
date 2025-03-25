using System;

namespace InterfaceExercise;

public class Truck : CommonBaseClass
{
    public int TowCapacity { get; set; }
    public int TruckPayLoad { get; set; }

    public Truck()
    {
        VehicleType = "truck";
    }

    public Truck(int towCapacity, int truckPayLoad)
    {
        TowCapacity = towCapacity;
        TruckPayLoad = truckPayLoad;
        VehicleType = "truck";
    }

    public override void DisplayAdditionalInfo()
    {
        Console.WriteLine($"The truck's tow capacity is {TowCapacity} and the truck payload is {TruckPayLoad}.");
    }
}