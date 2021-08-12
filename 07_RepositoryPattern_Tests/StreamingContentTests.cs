using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            StreamingContent movie = new StreamingContent();
            Console.WriteLine($"{movie.Title} is a {movie.GenreType} movie about {movie.Description} rated {movie.MaturityRating}");
        }

        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            // AAA Pattern

            //Arrange
            StreamingContent content = new StreamingContent();

            // Act
            content.Title = "Clerks";

            // Assert
            string expected = "Clerks";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.R, false)]
        public void SetMaturityRating_ShouldfGetCorrectFamilyFriendly
            (MaturityRating rating, bool expected)
        {   
            // Arrange
            StreamingContent content = new StreamingContent("Fateful Findings", "A fantastic movie", MaturityRating.G, 5.0, GenreType.SciFi);

            // Act
            bool actual = content.IsFamilyFriendly;
            //bool expected = true;

            // Assert
            Assert.AreEqual(actual, expected);
            //Assert.IsTrue(actual);
        }
    }
}
