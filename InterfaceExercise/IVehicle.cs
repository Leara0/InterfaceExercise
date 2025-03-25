namespace InterfaceExercise;

public interface IVehicle
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public enum States {excellent, good, fair, poor, terrible}
    public States Condition { get; set; }

    public void ShareVehicleAndCompanyInfo();

    public void DisplayAdditionalInfo();
}