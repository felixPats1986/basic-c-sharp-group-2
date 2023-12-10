// See https://aka.ms/new-console-template for more information

using Assignment4;

Console.WriteLine("Hello, World!");

var myCar = new Car(0);
myCar.Drive();
Console.Write("Give the amount of gasoline to refuel");
string? userInput = Console.ReadLine();
int.TryParse(userInput, out int amountToRefuel);
myCar.Refuel(amountToRefuel);
myCar.Drive();