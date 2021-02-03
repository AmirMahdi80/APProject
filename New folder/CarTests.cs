using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarTest()
        {

            Assert.Fail();
        }

        [TestMethod()]
        public void IsValidTest()
        {
            User user = new User("Ali", "mahdavi", "5321234");
            Car car = new Car("Pride","34M123456","20",user);
            Assert.AreEqual(car.IsValid(),true);
        }

        [TestMethod()]
        public void IsNativeTest()
        {
            User user = new User("Ali", "mahdavi", "5321234");
            Car car = new Car("Pride", "34M123456", "20", user);
            Assert.AreEqual(car.IsNative(), false);
            
        }
        [TestMethod()]
        public void IsNativeTest2()
        {
            User user = new User("Amir", "mahdavi", "5321236");
            Car car = new Car("Pride", "34M123433", "20", user);
            Assert.AreEqual(car.IsNative(), true);

        }

        [TestMethod()]
        public void IsInTest()
        {
            User user = new User("Ali", "mahdavi", "5321234");
            Car car = new Car("Pride", "34M123456", "20", user);
            Assert.AreEqual(car.IsIn(), true);
          
        }
        public void IsInTest2()
        {
            User user = new User("Amir", "mahdavi", "5321236");
            Car car = new Car("Pride", "34M123433", "20", user);
            Assert.AreEqual(car.IsIn(), true);

        }

        [TestMethod()]
        public void IsValidTest1()
        {
            Assert.Fail();
        }
    }
}