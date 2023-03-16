using System;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[2];
            Employee firstEmployee = new Employee()
            {
                Name = "A",
                Department = "Developers",


            };
            //firstEmployee.Name = "A";
            //employees[0] = firstEmployee;


            Employee secondEmployee = new Employee()
            {
                Name = "B",
                Department = "Developers",
            };

            //firstEmployee.Name = "B";
            //employees[1] = secondEmployee;
            for (int i = 0; i < employees.Length; i++) ;
            {
                employees[i].PrintInfo();
            }

        }
    }


    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Sound of " + Name);
        }

    }

    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int ID { get; set; }
        public string Department { get; set; }
        public string Team { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("Team of " + Name);

        }

       

    }
}
