using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurConsExample
{
    public class Employee
    {
        int id;
        string name;

        public Employee()
        {
            Console.WriteLine("Parameterless Constructor Call");
            id = -1;
            name = "not given";

        }

        public Employee(int id, string name)
        {
            Console.WriteLine("parameterized constructor");
            this.id = id;
            this.name = name;
        }
        public void Register()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("ID: \t"+id);
            Console.WriteLine("name:\t"+name);
        }

    }
}
