using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    Bread bread = new Bread(0,0);
    Pastry pastry = new Pastry(0,0); 

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
    public int BreadOrder()
    {
      int UserQuantity = 0;
      Console.WriteLine("How many loaf of bread you like to order");
      string UserSelectedQuantity = Console.ReadLine();
      UserQuantity = int.Parse(UserSelectedQuantity);
      bread.TotalCost = bread.BreadCost(UserQuantity);
      Console.WriteLine($"Your total bread cost ${bread.TotalCost}");
      Console.WriteLine("Would you like to order some pastries(if yes type y or type checkout");
      string UserInput = Console.ReadLine();
      if(UserInput == "y" || UserInput == "Y")
      {
        PastryOrder();
      }
      else
      {
        FinalCost();
      }
      return bread.TotalCost;
    }
    public int PastryOrder()
    {
      Console.WriteLine("How many pastries you like to order");
      string UserSelectedQuantity = Console.ReadLine();
      int UserQuantity = int.Parse(UserSelectedQuantity);
      pastry.TotalCost = pastry.PastryCost(UserQuantity);
      Console.WriteLine($"Your total Pastry cost ${pastry.TotalCost}");
      Console.WriteLine("Would you like to order some Breads(if yes type y or type checkout");
      string UserInput = Console.ReadLine();
      if(UserInput == "y" || UserInput == "Y")
      {
        BreadOrder();
      }
      else
      {
        FinalCost();
      }
      return pastry.TotalCost;
    }
    public int FinalCost()
    {
      int FinalCost = bread.TotalCost + pastry.TotalCost;
      Console.WriteLine($"Your total Pastry cost ${FinalCost}");
      Console.WriteLine("Thanks for selecting Pierre's Bakery");
      Console.WriteLine("Come again");
      return FinalCost;
    }
  }
}    