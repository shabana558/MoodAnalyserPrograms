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
        public object CreateMoodAnalyserParameterizedObject(string className, string constructor, string message)
        {
            try
            {
                Type type = typeof(MoodAnalyser);
                if (type.Name.Equals(className) || type.FullName.Equals(className))

                {
                    if (type.Name.Equals(constructor))
                    {
                        ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                        var obj = constructorInfo.Invoke(new object[] { message });
                        return obj;

                    }
                    else
                        throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor not found");
                }
                else
                {
                    throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.CLASS_NOT_FOUND, "class not found");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public object CreateMoodAnalyserParameterisedObject(string v1, string v2, string message)
        {
            throw new NotImplementedException();
        }
    }
}

            
        
    



        

       
    
    

