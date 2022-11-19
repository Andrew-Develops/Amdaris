using ConsoleUI;


IVehicle car = new VehicleFactory().CreateVehicle("Car");
car.MaxSpeed();

IVehicle truck = new VehicleFactory().CreateVehicle("Truck");
truck.MaxSpeed();

IVehicle motorcycle = new VehicleFactory().CreateVehicle("Motorcycle");
motorcycle.MaxSpeed();

public class Car : IVehicle
{
	public void MaxSpeed()
	{
		Console.WriteLine("The max speed of a car is 200mph");
	}
}

public class Motorcycle : IVehicle
{
	public void MaxSpeed()
	{
		Console.WriteLine("The max speed of a motorcycle is 180mph");
	}
}

public class Boat : IVehicle
{
	public void MaxSpeed()
	{
		Console.WriteLine("The max speed of a boat is 60mph");
	}
}

public class VehicleFactory
{
	public IVehicle CreateVehicle(string vehicleType)
	{
		switch (vehicleType.ToUpper())
		{
			case "CAR":
				return new Car();
			case "MOTORCYCLE":
				return new Motorcycle();
			case "BOAT":
				return new Boat();
			default:
				return null;
		}
	}
}

