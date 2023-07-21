using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 21,55,44,66,77};
            Console.WriteLine("All numbers");
            Console.WriteLine("total number in list are:"+numbers.Count);
            Console.WriteLine("capacity"+numbers.Capacity);
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(14);
            Console.WriteLine("total number in list "+numbers.Count);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("enter the number to search");
            int searchNumber = int.Parse(Console.ReadLine());
            if(numbers.Contains(searchNumber))
            {
                Console.WriteLine($"{searchNumber} is a part of list");
            }
            else
            {
                Console.WriteLine("not found");
            }
            Console.ReadKey();  
        }
    }
}
