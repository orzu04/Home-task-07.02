namespace task3;

public class Lock:IDevice
{
  public int Left { get; set; }
 public int Right { get; set; }

 public Lock(int left, int right)
{
   Left = left;
   Right = right;
}

public void TurnOff()
{
    if(Right>0)
    {
        System.Console.WriteLine($"Otkrilos");

    }
    else if(Right ==0)
    {
        System.Console.WriteLine($"Otkrito");
    }

}

public void TurnOn()
{
    if(Left>0)
    {
        System.Console.WriteLine($"Zakrilos");

    }


        else if(Left ==0)
    {
        System.Console.WriteLine($"Otkrito");
    }

}
}
