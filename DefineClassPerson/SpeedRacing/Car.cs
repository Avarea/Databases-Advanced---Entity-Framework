public class Car
{
    public string Model { get; set; }
    public double Fuel { get; set; }
    public double Consumption { get; set; }
    public double DistanceTravelled { get; set; }

    public Car(string Model, double Fuel, double Consumption)
    {
        this.Model = Model;
        this.Fuel = Fuel;
        this.Consumption = Consumption;
        this.DistanceTravelled = 0;
    }


    public bool Move(double distance)
    {
        double fuelNeeded = distance * this.Consumption;
        if (this.Fuel < fuelNeeded)
        {
            return false;
        }
        this.Fuel -= fuelNeeded;
        this.DistanceTravelled += distance;
        return true;
    }
}
