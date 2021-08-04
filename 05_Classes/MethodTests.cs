﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace _05_Classes
{
    [TestClass]
    public class MethodTests
    {
        [TestMethod]
        public void GreetingTests()
        {   
            // Instantiating an object
            Greeter greeter = new Greeter();

            //Calling a method from our variable of that object
            greeter.SayHello("Jacob");

            // Calling our overloaded method
            greeter.SayHello();

            greeter.RandomGreeting();
            // Thread sleep so we have some space between our random requests since its based on time
            Thread.Sleep(5);
            greeter.RandomGreeting();
            Thread.Sleep(5);
            greeter.RandomGreeting();
        }

        [TestMethod]
        public void Calculations()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Add(8, 12);
            Assert.AreEqual(20, sum);
            double sumTwo = calculator.Add(4.3, 9);
            Assert.AreEqual(13.3, sumTwo);
            double pro = calculator.Mul(7, 10);
            Assert.AreEqual(70, pro);

        }

        [TestMethod]
        public void AgeCalculations()
        {
            Calculator calculator = new Calculator();
            // 1, 21, 1992
            int age = calculator.CalculateAge(new DateTime(1992, 4, 21));
            Console.WriteLine($"Chris is {age} years old.");



        }
    }


}
