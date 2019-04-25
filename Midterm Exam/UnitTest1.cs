using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Midterm_Exam
{
    [TestClass]
    public class UnitTest1
    {
        Receipt receipt = new Receipt(124, "March 12", "Sam Smith", "Bradford", 098777,4555, 23.50, 2);

        ItemPrice item = new ItemPrice (12);


       

    
        [TestMethod]
        public void ValidItemNumber()
        {
            //arrange
            
            //act

            //assert
            Assert.AreEqual(receipt.ItemNumber, 4555);
        }

        [TestMethod]
        public void TotalCostCalculator()
        {
            Assert.AreEqual(receipt.TotalCost(), receipt.price * receipt.QuantityBought);
        }

        [TestMethod]

        public void PercentageIncreaseCalculator()
        {
            for (double i = 0.05; i < 0.1; i++)
            {
                double price = item.WholesalePrice * i;
                Console.WriteLine(price);
            }
        }
    }

    
}
