//Client

using CreationalPatterns.Factory;

IVehicle vehicle1 = new CarCreator().CreateVehicle();
Console.WriteLine(vehicle1.RunVehicle());

IVehicle vehicle2 = new TruckCreator().CreateVehicle();
Console.WriteLine(vehicle2.RunVehicle());