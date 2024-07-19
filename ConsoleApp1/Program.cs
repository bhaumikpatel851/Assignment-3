using System;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Brezza", "Maruti Suzuki", 2022, 70.0, 5, "Petrol", "Automatic", false);
        Truck truck1 = new Truck("Ashok Leyland", "Ashok Leyland", 2021, 150.0, 3000, "Cargo", false);
        Motorcycle motorcycle1 = new Motorcycle("Splender", "Hero", 2020, 50.0, 1000, "Petrol", false);

        Console.WriteLine("Car Details:");
        car1.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Truck Details:");
        truck1.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Motorcycle Details:");
        motorcycle1.DisplayDetails();
        Console.WriteLine();

        RentalAgency agency = new RentalAgency(15);

        agency.AddVehicle(car1);
        agency.AddVehicle(truck1);
        agency.AddVehicle(motorcycle1);

        Console.WriteLine("Renting out the motorcycle...");
        agency.RentVehicle("Splender");

        Console.WriteLine($"Total Revenue: ${agency.TotalRevenue}");
    }
}
