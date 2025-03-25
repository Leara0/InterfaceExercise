using System;

namespace InterfaceExercise;

public class Car : CommonBaseClass
{
    public int NumberOfSeats { get; set; }
    public int NumberOfDoors { get; set; }

    public Car()
    {
        VehicleType = "car";
    }

    public Car(int numberOfSeats, int numberOfDoors)
    {
        VehicleType = "car";
        NumberOfSeats = numberOfSeats;
        NumberOfDoors = numberOfDoors;
    }

    public override void DisplayAdditionalInfo()
    {
        Console.WriteLine($"The car has {NumberOfSeats} seats and {NumberOfDoors} doors.");
    }
}