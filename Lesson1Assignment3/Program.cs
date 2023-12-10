using Assignment3;

var dog = new Dog();


Console.Write("Give the dog a name");
string? userInput = Console.ReadLine();
dog.SetName(userInput!);
Console.WriteLine($"The dog's name is {dog.GetName()}");
dog.Eat();