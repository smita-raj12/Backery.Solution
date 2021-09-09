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
    [TestMethod]
    public void PastryCost_CalcutateTheCostWithDiscountFor_SixPastries()
    {
      int quantityOfPastry = 6;
      int totalCost = 10;
      Pastry pastry = new Pastry(quantityOfPastry, totalCost);
      int resultQuantityOfPastry = pastry.QuantityOfPastry;
      int ResultTotalCost = pastry.TotalCost;
      Assert.AreEqual(quantityOfPastry, resultQuantityOfPastry);
      Assert.AreEqual(totalCost, 10);
    }
    [TestMethod]
    public void PastryCost_CalcutateTheCostFor_TwoPastries()
    {
      int quantityOfPastry = 2;
      int totalCost = 4;
      Pastry pastry = new Pastry(quantityOfPastry, totalCost);
      int resultQuantityOfPastry = pastry.QuantityOfPastry;
      int ResultTotalCost = pastry.TotalCost;
      Assert.AreEqual(quantityOfPastry, resultQuantityOfPastry);
      Assert.AreEqual(totalCost, 4);
    }
  }
}  