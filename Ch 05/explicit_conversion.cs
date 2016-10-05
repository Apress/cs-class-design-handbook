using System;

public struct BigVehicle
{
	public string NumberPlate;
	public bool InService;
	public int Seats;
}

public class Bus
{
	string numberPlate;
	bool inService;
	int seats;
	public string NumberPlate{ set { numberPlate = value; } get { return numberPlate; }}
	public bool InService{ set { inService = value; } get { return inService; }}
	public int Seats{ set { seats = value; } get { return seats; }}

	public Bus(string numberPlate, int seats, bool inService)
	{
		this.numberPlate = numberPlate;
		this.seats = seats;
		this.inService = inService;
	}

	public static implicit operator BigVehicle(Bus bus)
	{
		BigVehicle big;
		big.NumberPlate = bus.NumberPlate;
		big.Seats = bus.Seats;
		big.InService = bus.InService;
		return big;
	}

	public static explicit operator Bus(BigVehicle big)
	{
		return new Bus(big.NumberPlate, big.Seats, big.InService);
	}
}

public class mainBus
{
	static void Main()
	{
		Bus bus2;
		BigVehicle big2;
		big2.InService = true;
		big2.NumberPlate = "Eazy Rider";	
		big2.Seats = 20;
		bus2 = (Bus)big2;

		Bus bus1 = new Bus("Eazy Rider", 20, true);
		BigVehicle big1 = bus1;
		
			
		Console.WriteLine("The Bus bus2 has {0} new seats",big2.Seats);
		Console.WriteLine(big2.NumberPlate);
		Console.WriteLine("Bus Inservice is {0}",big2.InService);
	}
}
