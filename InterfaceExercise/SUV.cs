using System;

namespace InterfaceExercise;

public class SUV:CommonBaseClass
{
    public bool FourWheelDrive { get; set; }
    public bool AllWheelDrive { get; set; }

    public SUV()
    {
        VehicleType = "SUV";
    }

    public SUV(bool fourWheelDrive, bool allWheelDrive)
    {
        FourWheelDrive = fourWheelDrive;
        AllWheelDrive = allWheelDrive;
        VehicleType = "SUV";
    }

    public override void DisplayAdditionalInfo()
    {
        Console.WriteLine($"This SUV does {(FourWheelDrive? "": "not")} have four wheel drive. " +
                          $"It {(AllWheelDrive? "has": "doesn't have")} all wheel drive.");
    }
}