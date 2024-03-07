#region Factory_execution

using CreationalPatterns.Abstract_Factory;
using CreationalPatterns.Builder;
using CreationalPatterns.Factory;
using CreationalPatterns.Prototype;
using CreationalPatterns.Singleton;
using System.Net.Http.Headers;

Console.WriteLine("Factory Pattern\n");

IVehicle vehicle1 = new CarCreator().CreateVehicle();
Console.WriteLine(vehicle1.RunVehicle());

IVehicle vehicle2 = new TruckCreator().CreateVehicle();
Console.WriteLine(vehicle2.RunVehicle());

Console.WriteLine("--------------------------------");
#endregion

#region AbstractFactory_execution
Console.WriteLine("Abstract Factory Pattern\n");

string option = "light";
switch (option)
{
    case "light":
        var lightButton = new ConcreteElementsLightFactory().CreateButton();
        Console.WriteLine(lightButton.Render());
        var lightLabel = new ConcreteElementsLightFactory().CreateLabel();
        Console.WriteLine(lightLabel.GetText());
        break;
    case "dark":
        var darkButton = new ConcreteElementsDarkFactory().CreateButton();
        Console.WriteLine(darkButton.Render());
        var darkLabel = new ConcreteElementsDarkFactory().CreateLabel();
        Console.WriteLine(darkLabel.GetText());
        break;
    default: 
        Console.WriteLine("Invalid option!");
        break;
}
    
        


Console.WriteLine("--------------------------------");
#endregion

#region Builder_execution
Console.WriteLine("Builder Pattern\n");

RobotBuilder robotBuilder = new RobotBuilder();
RobotDirector director = new RobotDirector(robotBuilder);

//Creating an assistant Robot
Robot assistantRobot = director.CreateAssitantRobot();
assistantRobot.ColorizedStringOutput(assistantRobot.ToString());
Console.WriteLine("\n\n");

//Creating a Combat Robot
Robot combatRobot = director.CreateCombatRobot();
combatRobot.ColorizedStringOutput(combatRobot.ToString());

Console.WriteLine("--------------------------------");
#endregion

#region Prototype_Execution
Console.WriteLine("Prototype Pattern\n");

Dog dog = new Dog("Fluffy", "Siberian");
Dog clonedDog = (Dog) dog.Clone();
Console.WriteLine($"Cloned {clonedDog.GetType().Name}  {clonedDog.Name} race: {clonedDog.Race}\nCloned dog = dog???: {clonedDog.Equals(dog)}\n");

Cat cat = new Cat("Sparky", "Siamese");
Cat clonedCat = (Cat) cat.Clone();
Console.WriteLine($"Cloned {clonedCat.GetType().Name}  {clonedCat.Name} race: {clonedCat.Race}\nCloned dog = dog???: {clonedCat.Equals(cat)}\n");


Console.WriteLine("--------------------------------");
#endregion

#region Singleton_Execution
Console.WriteLine("Singleton Pattern\n");

Database myDatabase = Database.GetDatabaseInstance();
myDatabase.query("SELECT * FROM Costumers;");

Database mySameDatabase = Database.GetDatabaseInstance();
mySameDatabase.query("SELECT * FROM Products;");

Console.WriteLine("HashCode object: "+ myDatabase.GetHashCode()); 
Console.WriteLine("HashCode object: "+ mySameDatabase.GetHashCode());
Console.WriteLine("Same intance?: "+ myDatabase.Equals(mySameDatabase));

Console.WriteLine("--------------------------------");
#endregion