using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDisposableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example-1
            /*FileHandeler fileHandeler = new FileHandeler("sam file  one");
            fileHandeler.GetFileDetails();
            fileHandeler.Dispose();
            FileHandeler fileHandeler2 = new FileHandeler("sam file two");
            fileHandeler2.GetFileDetails();*/

            //example-2 using
            using (FileHandeler obj1 = new FileHandeler("Document-001"))
            {
                obj1.GetFileDetails();
            }
            using (FileHandeler obj2 = new FileHandeler("Document-002"))
            {
                obj2.GetFileDetails();
            }
            Console.ReadKey();  
        }
    }
}
