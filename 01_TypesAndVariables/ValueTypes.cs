using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            // Declared Bool
            bool declared;

            //assigning value
            declared = true; //Bools are on or off - True or False

            // declared and assigned
            bool declaredAndInitialized = false;

            //Still assign value after initial assignment
            declaredAndInitialized = true;


        }


        [TestMethod]
        public void Characters()
        {
            //Anything more than one character has to be a string
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteMin = 0;
            byte byteMax = 255;
            short shortMin = -32768;
            short shortMax = 32767;
            int intMin = -2147483648;
            int intMax = 2147483647;
            long longMin = -9223372036854775808;
            long longMax = 9223372036854775807;
            int a = 15;
            int b = -2;
        }

        [TestMethod]
        public void Decimals()
        {
            // float numbers need f at the end
            float floatexample = 1.29294894f;

            // doesnt need a suffix but it can be signafied with a d for organization
            double doubleExample = 1.749292474748d;

            // You need an m at the end of a decimal
            decimal decimalExample = 1.29239921923200099m;

        }
        // variables are camel - classes and namespaces are Pascal
        enum PastryType { Cake, Cupcake, Eclaire, PetitFour, Croissant };

        [TestMethod]
        public void Enum()
        {
            PastryType myPastry = PastryType.Croissant;
            PastryType yourPastry = PastryType.PetitFour;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1972, 4, 3);
            
        }
    }

}
