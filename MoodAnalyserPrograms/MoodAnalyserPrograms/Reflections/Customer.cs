using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserPrograms.Reflections
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer()
        {
            Console.WriteLine("default constructor");

        }
        public Customer(int Id, string Name)
        {
            Console.WriteLine("Parameterised constructor");
            this.Id = Id;
            this.Name = Name;
        }
        public void printId()
        {
            Id = 20;
            Console.WriteLine("Customer Id is:" +Id);
        }
        public void PrintName()
        {
            Name = "Abc";
            Console.WriteLine("Customer Name is:" +Name);

        }
    }
}
