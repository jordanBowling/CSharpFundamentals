using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        //Addition
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        // Subtraction
        public int Sub(int subOne, int subTwo)
        {
         
            return subOne - subTwo;
        }

        // Multiplication
        public int Mul(int multOne, int multTwo)
        {
            return multOne * multTwo;
        }

        // Division
        public int Div(int divOne, int divTwo)
        {
            return divOne / divTwo;
        }

        // Age Calculation
        public int CalculateAge(DateTime birthDate)
        {
            TimeSpan ageSpan = DateTime.Now - birthDate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            double ageRounded = Math.Floor(totalAgeInYears);
            int years = Convert.ToInt32(ageRounded);
            return years;
        }
    }
}
