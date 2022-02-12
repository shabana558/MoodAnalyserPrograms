using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserPrograms
{ 
      //creating MoodAnalyser class
    public class MoodAnalyser
       {
     public string Message;
    public MoodAnalyser()
    {
        Console.WriteLine("default constructor");
    }
    public MoodAnalyser(string message)
    {
        this.Message = message;
    }
    //public string AnalyseMood();
    //    {
    //    try
    //        {
    //            if (this.Message.ToLower().Contains("happy"))

    //            {
    //        return "happy";
    //    }
    //            else if (this.Message.Equals(string.Empty))
    //            {
    //        throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.EMPTY_MOOD_EXCEPTION, "message should not be empty");
    //    }
    //            else
    //            {
    //        return "sad";
    //    }
    //    }
    //        catch (NullReferenceException ex)
    //        {
    //            Console.WriteLine(ex);
    //            return "happy";
    //            throw new NullReferenceException();
    //            throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NULL_MOOD_EXCEPTION, "message should not be null");
        public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (!(obj is MoodAnalyser))
        {
            return false;
        }
        MoodAnalyser moodAnalyseObject = (MoodAnalyser)obj;
        return this.Message == moodAnalyseObject.Message;

            try
            {
                if (this.Message.ToLower().Contains("happy"))

                {
                    return "happy";
                }
                else if (this.Message.Equals(string.Empty))
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.EMPTY_MOOD_EXCEPTION, "message should not be empty");
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex);
                return "happy";
                throw new NullReferenceException();
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NULL_MOOD_EXCEPTION, "message should not be null");


