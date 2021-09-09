using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      int quantityOfPastry = 3;
      int totalCost = 5;
      Pastry pastry = new Pastry(quantityOfPastry, totalCost);
      int resultQuantityOfPastry = pastry.QuantityOfPastry;
      int ResultTotalCost = pastry.TotalCost;
      Assert.AreEqual(quantityOfPastry, resultQuantityOfPastry);
      Assert.AreEqual(totalCost, ResultTotalCost);
    }
    [TestMethod]
    public void PastryCost_CalcutateTheCostWithDiscount_MoreThanThree()
    {
      int quantityOfPastry = 4;
      int totalCost = 7;
      Pastry pastry = new Pastry(quantityOfPastry, totalCost);
      int resultQuantityOfPastry = pastry.QuantityOfPastry;
      int ResultTotalCost = pastry.TotalCost;
      Assert.AreEqual(quantityOfPastry, resultQuantityOfPastry);
      Assert.AreEqual(totalCost, 7);
    }
    [TestMethod]
  public void PastryCost_CalcutateTheCostWithDiscountFor_FivePastries()
    {
      int quantityOfPastry = 5;
      int totalCost = 9;
      Pastry pastry = new Pastry(quantityOfPastry, totalCost);
      int resultQuantityOfPastry = pastry.QuantityOfPastry;
      int ResultTotalCost = pastry.TotalCost;
      Assert.AreEqual(quantityOfPastry, resultQuantityOfPastry);
      Assert.AreEqual(totalCost, 9);
    }
    /*[TestMethod]
    public void BreadCost_CalcutateTheCost_WithOneBread()
    {
      int quantityOfBread = 1;
      int totalCost = 5;
      Bread bread = new Bread(quantityOfBread, totalCost);
      int resultQuantityOfBread = bread.QuantityOfBread;
      int ResultTotalCost = bread.TotalCost;
      Assert.AreEqual(quantityOfBread, resultQuantityOfBread);
      Assert.AreEqual(totalCost, 5);
    }*/
  }
}  