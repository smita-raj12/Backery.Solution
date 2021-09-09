using System;

namespace  Bakery.Models
{
  public class Pastry
  {
    public int QuantityOfPastry {get; set;}
      public int TotalCost {get; set;}

      public Pastry(int quantityOfPastry, int totalCost)
      {
          QuantityOfPastry = quantityOfPastry;
          TotalCost = totalCost;
      }
      public int PastryCost(int quantityOfPastry){
          int OnePastryCost = 2;
          int freePastry = quantityOfPastry/3;
          if (quantityOfPastry % 3 == 0){
          TotalCost = (OnePastryCost * quantityOfPastry) - (freePastry);
        }
        else
        {
          TotalCost = OnePastryCost * quantityOfPastry;
        }
        return TotalCost;
      }
  }
}      