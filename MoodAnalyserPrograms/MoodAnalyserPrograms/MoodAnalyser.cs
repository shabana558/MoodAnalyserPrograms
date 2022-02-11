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
        public MoodAnalyser(string message)
        {
            this.Message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (this.Message.ToLower().Contains("happy"))

                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return "happy";
               throw new NullReferenceException();
            }
        }
    }

}
