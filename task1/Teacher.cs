namespace task1;

public class Teacher:Person
{

  public string Sabjact { get; set; }

   public Teacher (string name, int age,string sabjact):base(name,age)
   {
    Sabjact = sabjact;
   }

   public void Explain()

{
    if(Age<25)
    {
        System.Console.WriteLine($"Not Teacher");

    }
    else 
    {
        System.Console.WriteLine($"My name {Name} year{Age} old my sabjact {Sabjact}. I'm explaining");
    }
}   


}
