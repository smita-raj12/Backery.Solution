using System;

namespace  Bakery.Models
{
  public class Bread
  {
    public int QuantityOfBread {get; set;}
    public int TotalCost {get; set;}

    public Bread(int quantityOfBread, int totalCost)
    {
      QuantityOfBread = quantityOfBread;
      TotalCost = totalCost;
    }
    public int BreadCost(int quantityOfBread)
    {
      int OneBreadCost = 5;
      int freeBread =  quantityOfBread/3;
      if (quantityOfBread % 3 == 0)
      {
        TotalCost = (OneBreadCost * quantityOfBread) - (OneBreadCost * freeBread);
      }
      else if(quantityOfBread < 3)
      {
        TotalCost = OneBreadCost * quantityOfBread;
      }
      else
      {
        TotalCost =  (OneBreadCost * quantityOfBread) - OneBreadCost;
      }
      return TotalCost;
    }
  }
}