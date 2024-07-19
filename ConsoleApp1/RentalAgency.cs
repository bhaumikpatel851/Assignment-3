using System;

public class RentalAgency
{
    private Vehicle[] Fleet { get; set; }
    public double TotalRevenue { get; private set; }

    public RentalAgency(int capacity)
    {
        Fleet = new Vehicle[capacity];
        TotalRevenue = 0;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] == null)
            {
                Fleet[i] = vehicle;
                break;
            }
        }
    }

    public void RemoveVehicle(string model)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] != null && Fleet[i].Model == model)
            {
                Fleet[i] = null;
                break;
            }
        }
    }

    public void RentVehicle(string model)
    {
        for (int i = 0; i < Fleet.Length; i++)
        {
            if (Fleet[i] != null && Fleet[i].Model == model)
            {
                TotalRevenue += Fleet[i].RentalPrice;
                Fleet[i] = null;
                break;
            }
        }
    }
}