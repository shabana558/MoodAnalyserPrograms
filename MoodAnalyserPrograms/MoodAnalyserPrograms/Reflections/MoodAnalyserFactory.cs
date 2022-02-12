using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyserPrograms.Reflections
{
    public class MoodAnalyserFactory
    {
        public object CreateMoodAnalyserObject(string className, string constructor)   
        {
            string pattern = "." + constructor + "$";
            ; Match result = Regex.Match(className, pattern);
            //Regex.IsMatch(ClassName,Pattern)

            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    //Type[] classes=assembly.GetTypes();
                    //{
                    //  Console.WriteLine(Type.FilterName + " " + Type.FullName);
                    //
                    //}
                    Type moodAnalyserType = assembly.GetType(className);
                    var res = Activator.CreateInstance(moodAnalyserType);
                    return res;

                }
                catch (Exception ex)
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.CLASS_NOT_FOUND, "class not found");
                }
            }
            else
            {
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor not found");

        }


            }

       
    }
    }

