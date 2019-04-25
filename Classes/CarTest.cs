using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void CarColourSet()
        {
           
            
                //arrange
                Car car = new Car("blue", 5, true);

                //act

                //assert
                StringAssert.Equals(car.Colour,"blue");
            
        }
        [TestMethod]
        public void FullNameReturned()
        {
            Employee employee = new Employee(154542, "Gagan", "Singh", "March 17 2018", "Software Tester", "IT", 90);

            string fullName= employee.ReturnFullName();

            StringAssert.Equals(fullName, "Gagan Singh"); 
        }

        [TestMethod]
        public void FullNameReturnedForSorting()
        {
            Employee employee = new Employee("Gagan", "Singh");
            string fullName = employee.ReturnFullNameForSorting();

            StringAssert.Equals(fullName, "Singh, Gagan");
        }
        

        //public void MonthlySalaryTooLow()
        //{
        //    Employee employee = new Employee(154542, "Gagan", "Singh", "March 17 2018", "Software Tester", "IT", 90);

        //    Assert.ThrowsException(ArgumentException, "value is too low for monthly salary");
        //}
        [TestMethod]
        public void ReturnFamilyCarMethod()
        {
            Car car = new Car("blue", 4, true);

            bool carType = car.FamilyCar();

            if (carType==true)
            {
                Assert.IsTrue(carType == true);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
