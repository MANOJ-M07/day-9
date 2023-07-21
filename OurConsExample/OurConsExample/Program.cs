using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurConsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Display();
            Employee employee2 = new Employee(12,"sam"); 
            employee2.Display();
            Employee employee3 = new Employee();
            employee3.Register();
            employee3.Display();

            Console.ReadKey();  
        }
    }
}
