﻿namespace task1;

public class Person
{

   public string Name { get; set; }
   public int Age { get; set; }
   

   public Person(string name,int age)
   {
     Name = name;
     Age = age;
   }
   
  public void Greet ()
  {
    System.Console.WriteLine( $" Hello!");
  }

  public void GetAde()
  {
    System.Console.WriteLine($" Name: {Name}");
    System.Console.WriteLine($" Age: {Age}");
  }

}
