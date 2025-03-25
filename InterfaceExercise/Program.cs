using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car()
            {
                NumberOfSeats = 4,
                NumberOfDoors = 4,
                Year = 2010,
                Make = "Honda",
                Model = "Accord",
                Condition = IVehicle.States.fair,
                Nationality = "Japanese",
                Logo = "'H' with a square around it"
            };
            
            var car2 = new Car(4,4)
            {
                Year = 2020,
                Make = "BMW",
                Model = "M5 Sedan",
                Condition = IVehicle.States.good,
                Nationality = "German",
                Logo = "blue and white circle with BMW on top"
            };
            
            var truck1 = new Truck()
            {
                TowCapacity = 40000,
                TruckPayLoad = 1395,
                Year = 2018,
                Make = "Ford",
                Model = "F-450",
                Condition = IVehicle.States.good,
                Nationality = "American",
                Logo = "blue oval with the word Ford"
            };
            var truck2 = new Truck(12000, 1200)
            {
                Year = 2024,
                Make = "Toyota",
                Model = "Tundra",
                Condition = IVehicle.States.excellent,
                Nationality = "Japanese",
                Logo = "overlapping ovals to symbolize 'T'"
            };
            var SUV1 = new SUV()
            {
                FourWheelDrive = false,
                AllWheelDrive = true,
                Year = 2020,
                Make = "Honda",
                Model = "CR-V",
                Condition = IVehicle.States.good,
                Nationality = "Japanese",
                Logo = "'H' with a square around it"
            };
            var SUV2 = new SUV(false, true)
            {
                Year = 2010,
                Make = "Mazda",
                Model = "CX-50",
                Condition = IVehicle.States.poor,
                Nationality = "Japanese",
                Logo = "circle with 'V' that makes an 'M'"
            };

            var VehicleList = new List<IVehicle>()
            {
                car1,
                car2,
                truck1,
                truck2,
                SUV1,
                SUV2
            };
            
            VehicleExtension.WelcomeMethod(car1);
            
            for (int i = 0; i < VehicleList.Count; i++)
            {
                VehicleList[i].ShareVehicleAndCompanyInfo();
                VehicleList[i].DisplayAdditionalInfo();
                Console.WriteLine("");
            }
            
            
            
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
