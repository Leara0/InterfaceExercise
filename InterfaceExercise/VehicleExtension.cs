using System;
using System.Runtime.CompilerServices;

namespace InterfaceExercise;

public static class VehicleExtension
{
    public static void WelcomeMethod(this IVehicle vehicle)
    {
        Console.WriteLine("Thank you for using the Vehicle Extension");
        
    }
}