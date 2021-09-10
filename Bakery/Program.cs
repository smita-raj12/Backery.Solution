using System;
using System.Collections.Generic;
using Bakery.Models;


namespace Bakery
{
  public class Program
  {
    public Bread bread;
    public Pastry pastry; 
    public static void Main()
    {
      Program program = new Program();
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("***************************");
      Console.WriteLine("Here you can order a loaf Bread for 5$ and a Pastry for $2");
      Console.WriteLine("Enter your choice, For bread type bread or type pastry");
      string UserChoice = Console.ReadLine();
      if(UserChoice == "bread")
      {
        program.BreadOrder();
      }
      else if(UserChoice == "pastry")
      {
        program.PastryOrder();
      }
      else
      {
        Console.WriteLine("Don't waste my time go away, there is a big line behind you");
      }
    }
    public string BreadOrder()
    {
      Console.WriteLine("How many loaf of bread you like to order");
      string UserSelectedQuantity = Console.ReadLine();
     // int UserQuantity = int.Parse(UserSelectedQuantity);
     //Bread newBread = new Bread(UserQuantity);
      Console.WriteLine(UserSelectedQuantity); 
      return UserSelectedQuantity;
    }
    public string PastryOrder()
    {
      Console.WriteLine("How many loaf of bread you like to order");
      string UserSelectedQuantity = Console.ReadLine();
     // int UserQuantity = int.Parse(UserSelectedQuantity);
     //Bread newBread = new Bread(UserQuantity);
      Console.WriteLine(UserSelectedQuantity); 
      return UserSelectedQuantity;
    }
  }
}    