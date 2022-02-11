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
            string expected = "Object reference not set to an instance of an object";
            MoodAnalyser mood = new MoodAnalyser(message);

            try
            {
                //Act
                string actual = mood.AnalyseMood();
            }
            catch (NullReferenceException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
        [TestCategory("Exception")]
        [TestMethod]
        public void GivenNullMessageReturnCustomException()
        {
            ///AAA
            ///Arrange
            string message = "null";
            string expected = "Message should not be null";
            MoodAnalyser mood = new MoodAnalyser(message);
            try
            {
                //Act
                string actual = mood.AnalyseMood();
            }
            catch (NullReferenceException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
        [TestCategory("CustomException")]
        [TestMethod]
        public void GivenEmptyMessageReturnCustomException()
        {
            ///AAA
            ///Arrange
            string message = null;
            string expected = "Message should not be empty";
            MoodAnalyser mood = new MoodAnalyser(message);
            try
            {
                //Act
                string actual = mood.AnalyseMood();
            }
            catch (CustomMoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
            //Assert
        }


    }

    
}
