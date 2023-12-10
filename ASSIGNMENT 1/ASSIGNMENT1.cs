namespace ASSIGNMENT_1;

class StudentProfessorTest
{
    static void Main()
    {
        // Create a new Person and make him say hello
        Person person = new Person();
        person.Greet();

        // Create a new Student, set an age, say hello, and display her age on the screen
        Student student = new Student();
        student.SetAge(20);
        student.Greet();
        student.ShowAge();

        // Create a new Teacher, set an age, say hello, and start the explanation
        Teacher teacher = new Teacher();
        teacher.SetAge(30);
        teacher.Greet();
        teacher.Explain();
    }
}
class Person
{
    private int age;

    public void Greet()
    {
        Console.WriteLine("Hello!");
    }

    public void SetAge(int age)
    {
        this.age = age;
    }
}

class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I'm studying.");
    }

    public void ShowAge()
    {
        Console.WriteLine($"My age is: {base.Age} years old.");
    }
}

class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("I'm explaining.");
    }
}