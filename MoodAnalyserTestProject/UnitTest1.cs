using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserPrograms;

namespace MoodAnalyserTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestCategory("Exception")]
        [TestMethod]
        public void GivenHappyMessageReturnHappyMood()
        {
            ///AAA
            ///Arrange
            string message = "I am in Happy Mood";
            string expected = "happy";
            MoodAnalyser mood = new MoodAnalyser(message);

            //Act
            string actual = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestCategory("Exception")]
        [TestMethod]
        public void GivensadMessageReturnsadMood()
        {
            ///AAA
            ///Arrange
            string message = "I am in SAD Mood";
            string expected = "sad";
            MoodAnalyser mood = new MoodAnalyser(message);

            //Act
            string actual = mood.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestCategory("Exception")]
        [TestMethod]
        public void GivenNullMessageReturnHappyMood()
        {
            ///AAA
            ///Arrange
            string message = null;
            string expected = "happy";
            MoodAnalyser mood = new MoodAnalyser(message);
            string actual = null;
            try
            {
                //Act
                actual = mood.AnalyseMood();
            }
            catch (NullReferenceException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
            //Assert
            Assert.AreEqual(expected, actual);


        }
        [TestCategory("Exception")]
        [TestMethod]
        public void GivenNullMessageReturnException()
        {
            ///AAA
            ///Arrange
            string message = "null";
            string expected = "object reference not set to an instance of an object";
            MoodAnalyser mood = new MoodAnalyser(message);
            string actual = null;
            try
            {
                //Act
                actual = mood.AnalyseMood();
            }
            catch (NullReferenceException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }


        }
    }
}
