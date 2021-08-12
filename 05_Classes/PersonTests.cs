using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void personPropertyTests()
        {
            Person firstPerson = new Person("Jordan", "Bowling", new DateTime(1990, 02, 20), "210-69-2323", 800);

            //firstPerson.FirstName = "Jordan";
            //firstPerson.LastName = "Bowling";
            //firstPerson.DateOfBirth = new DateTime(1990, 2, 20);
            //firstPerson.SocialSecurity = "210-69-2323";
            //firstPerson.CreditScore = 800;

            Console.WriteLine($"{firstPerson.FullName} was born on {firstPerson.DateOfBirth.ToShortDateString()}");

            Console.WriteLine($"{firstPerson.LastName} {firstPerson.SocialSecurity}");

            firstPerson.Transport = new Vehicle("VolksWagon", "Passat 2.0T", 40000, VehicleType.Car);

            Console.WriteLine($"{firstPerson.FirstName} drives a {firstPerson.Transport.Make} {firstPerson.Transport.Model}");

            Assert.AreEqual("Jordan B", firstPerson.FullName);

            firstPerson.Transport.TurnOn();

            Assert.IsTrue(firstPerson.Transport.IsRunning);

        }
    }
}
