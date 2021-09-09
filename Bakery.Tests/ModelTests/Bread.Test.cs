using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      int quantityOfBread = 3;
      int totalCost = 10;
      Bread bread = new Bread(quantityOfBread, totalCost);
      int resultQuantityOfBread = bread.QuantityOfBread;
      int ResultTotalCost = bread.TotalCost;
      Assert.AreEqual(quantityOfBread, resultQuantityOfBread);
      Assert.AreEqual(totalCost, ResultTotalCost);
    }
    [TestMethod]
    public void BreadDiscount_CalcutateTheCostWithDiscount_MoreThanThree()
    {
      int quantityOfBread = 5;
      int totalCost = 20;
      Bread bread = new Bread(quantityOfBread, totalCost);
      int resultQuantityOfBread = bread.QuantityOfBread;
      int ResultTotalCost = bread.TotalCost;
      Assert.AreEqual(quantityOfBread, resultQuantityOfBread);
      Assert.AreEqual(totalCost, 20);
    }
    [TestMethod]
    public void BreadCost_CalcutateTheCostWithDiscount_MoreThanfive()
    {
      int quantityOfBread = 6;
      int totalCost = 20;
      Bread bread = new Bread(quantityOfBread, totalCost);
      int resultQuantityOfBread = bread.QuantityOfBread;
      int ResultTotalCost = bread.TotalCost;
      Assert.AreEqual(quantityOfBread, resultQuantityOfBread);
      Assert.AreEqual(totalCost, 20);
    }
     [TestMethod]
    public void BreadCost_CalcutateTheCost_WithOneBread()
    {
      int quantityOfBread = 1;
      int totalCost = 5;
      Bread bread = new Bread(quantityOfBread, totalCost);
      int resultQuantityOfBread = bread.QuantityOfBread;
      int ResultTotalCost = bread.TotalCost;
      Assert.AreEqual(quantityOfBread, resultQuantityOfBread);
      Assert.AreEqual(totalCost, 5);
    }
  }
}  