using System;

namespace InterfaceExercise;

public class CommonBaseClass : ICompany, IVehicle
{
    public string Logo { get; set; }
    public string Nationality { get; set; }
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public IVehicle.States Condition { get; set; }
    
    public string VehicleType { get; set; }
    
    public virtual void ShareVehicleAndCompanyInfo()
    {
        Console.WriteLine($"This {VehicleType} is a {Year} {Make} {Model}. {Make} is a {Nationality} company. " +
                          $"Their logo is a/n {Logo}. The vehicle is in {Condition} condition.");
    }

    public virtual void DisplayAdditionalInfo()
    {
        
    }

    }