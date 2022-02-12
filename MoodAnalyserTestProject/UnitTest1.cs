using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserPrograms;
using MoodAnalyserPrograms.Reflections;

namespace MoodAnalyserTestProject
{
    [TestClass]
    public class MoodAnalyserTestClass
    {
        MoodAnalyserFactory factory;
        public void Setup()
        {
            factory = new MoodAnalyserFactory();
        }


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
        ///Tc-4-Create default constructor using reflection
        ///
        [TestCategory("Reflection")]
        [TestMethod]
        public void Given_MoodAnalyser_using_Reflection_Return_defaultConstructor()
        {
            Customer expected = new Customer();
            object obj = null;
            try
            {
                //Act
                obj = factory.CreateMoodAnalyserObject("MoodAnalyserPrograms.MoodAnalyser", "MoodAnalyser");
            }
            catch (CustomMoodAnalyserException exception)
            {
                //Assert
                throw new Exception(exception.Message);

            }
            // obj.Equals(expected);
            Assert.AreEqual(expected, obj);
        }

        [TestCategory("Reflection")]
        [TestMethod]
        public void Given_MoodAnalyserwithMessage_Using_reflection_Return_ParameterisedConstructor()
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser(message);
            object actual = null;
            try
            {
                // MoodAnalyserFactory=new MoodAnalyserFactory();
                //Act
                actual = factory.CreateMoodAnalyserParameterisedObject("MoodAnalyser", "MoodAnalyser", message);
            }
            catch (CustomMoodAnalyserException exception)
            {
                //Assert
                throw new Exception(exception.Message);
            }
            actual.Equals(expected);
        }
    }

}



    



