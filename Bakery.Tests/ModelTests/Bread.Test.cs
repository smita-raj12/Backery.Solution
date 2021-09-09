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
  }
}  