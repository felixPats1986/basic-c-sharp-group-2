using Assignment1;


var person = new Person();
var student = new Student();
var teacher = new Teacher();

person.Greet();
student.SetAge(15);
student.Greet();
Console.WriteLine(student.Age);
teacher.SetAge(33);
teacher.Greet();
Console.WriteLine(teacher.Age);

