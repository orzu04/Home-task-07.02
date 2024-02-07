namespace task3;

public class Lamp:IDevice
{

   public int Knopka { get; set; }

  public Lamp(int knopka)
  {
    Knopka = knopka;
  }

  public void TurnOff()
  {
    if(Knopka<0)
    {
        System.Console.WriteLine($"Giryon kn");
    }
   
  }
   public void TurnOn()
  {
    if(Knopka>0)
    {
        System.Console.WriteLine($"Giryonay");
    }
   
  }

}
