using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserPrograms
{
    public class Program
    {
      
        static void Main(string[] args)
        {
            FetchCustomerTypeInfo();
            Console.ReadLine();
        }
        public static void FetchCustomerTypeInfo()
        {
            string path = @"G:\shabana\MoodAnalyserPrograms\MoodAnalyserPrograms\MoodAnalyserPrograms\bin\Debug.exe";
          //  Type type = Type.GetType(" MoodAnalyserPrograms.Customer");
          Assembly assembly = Assembly.LoadFrom(path);
            Type[] types=assembly.GetTypes();
            foreach (Type type1 in types)
            {
                Console.WriteLine(type1.Name);
            }
            Type type = Type.GetType("MoodAnalyserPrograms.Customer");
            Console.WriteLine("FullName of class:"+type.FullName);
            Console.WriteLine("Name of  the class:" + type.Name);

            ConstructorInfo[] constructorInfos = type.GetConstructors();
            Console.WriteLine("Constructors");
            foreach (ConstructorInfo constructor in constructorInfos)
            {
                Console.WriteLine(constructor.ToString());
            }

            PropertyInfo[] propertyInfos = type.GetProperties();
            Console.WriteLine("properties");
            foreach (PropertyInfo property in propertyInfos)
            {
                Console.WriteLine(property.Name+" "+property.PropertyType);
            }
            MethodInfo[] methods=type.GetMethods();
            Console.WriteLine("Methods");
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name+" "+method.ReturnType.Name);

            }


        }
    }
}
