namespace task1;

public class Student : Person
{

    public int Course { get; set; }

    public Student(string name, int age, int course) : base(name, age)
    {
        Course = course;
    }

    public void Study()
    {
        System.Console.WriteLine($"My name is {Name} . My age is {Age} years old. My course is {Course}");
    }

    public void ShowAge()
    {
        System.Console.WriteLine($"I'm studing ");
    }


}
