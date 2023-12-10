namespace Assignment1;

public class Person
{
    
    public int Age { get; set; }
    
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }

    public void SetAge(int age)
    {
        Age = age;
    }
}