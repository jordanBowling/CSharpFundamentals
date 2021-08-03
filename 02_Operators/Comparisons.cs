using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparisons
    {
        [TestMethod]
        public void Comparison()
        {
            int age = 25;
            string userName = "Joshua";

            bool equals = age == 41;
            bool userIsAdam = userName == "Adam";

            //Inequals comparison
            bool notEqual = age != 112;
            bool userIsNotJustin = userName != "Justin";

            //Not all things are equal, referance types aren't understood the same way
            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool isEqual = firstList == secondList;

            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 24;
            bool lessThan = age < 66;
            bool lessThanEqualTo = age <= 24;

        }

        [TestMethod]
        public void AndOr()
        {
            bool trueValue = true;
            bool falseValue = false;

            //Or ||
            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrF = falseValue || falseValue;

            // And && 
            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndF = falseValue && falseValue;


        }
    }
}
