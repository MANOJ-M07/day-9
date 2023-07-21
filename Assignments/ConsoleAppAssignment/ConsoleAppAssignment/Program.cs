using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        
        List<string> initialDataStrings = GetDataFromUser<string>("Enter initial data elements (type 'done' when finished): ");

       
        using (var largeStringDataCollection = new LargeDataCollection<string>(initialDataStrings))
        {
            Console.WriteLine("\nInitial Collection contents:");
            for (int i = 0; i < initialDataStrings.Count; i++)
            {
                Console.WriteLine(largeStringDataCollection.GetElement(i));
            }

           
            List<string> elementsToAddStrings = GetDataFromUser<string>("Enter a string element to add (type 'done' to stop adding): ");
            foreach (string elementToAdd in elementsToAddStrings)
            {
                largeStringDataCollection.AddElement(elementToAdd);
            }

            
            List<string> elementsToRemoveStrings = GetDataFromUser<string>("Enter a string element to remove (type 'done' to stop removing): ");
            foreach (string elementToRemove in elementsToRemoveStrings)
            {
                if (largeStringDataCollection.RemoveElement(elementToRemove))
                {
                    Console.WriteLine($"Element '{elementToRemove}' removed successfully.");
                }
                else
                {
                    Console.WriteLine($"Element '{elementToRemove}' not found in the collection.");
                }
            }

            Console.WriteLine("\nCollection contents after adding and removing string elements:");
            for (int i = 0; i < initialDataStrings.Count;i++)
            {
                Console.WriteLine(largeStringDataCollection.GetElement(i));
                
            }
        }

       
        List<int> initialIntData = GetDataFromUser<int>("Enter initial integer data elements (type 'done' when finished): ");

        
        using (var largeIntDataCollection = new LargeDataCollection<int>(initialIntData))
        {
            Console.WriteLine("\nInitial Collection contents:");
            for (int i = 0; i < largeIntDataCollection.Count; i++)
            {
                Console.WriteLine(largeIntDataCollection.GetElement(i));
            }

            
            List<int> elementsToAddInt = GetDataFromUser<int>("Enter an integer element to add (type 'done' to stop adding): ");
            foreach (int elementToAdd in elementsToAddInt)
            {
                largeIntDataCollection.AddElement(elementToAdd);
            }

            
            List<int> elementsToRemoveInt = GetDataFromUser<int>("Enter an integer element to remove (type 'done' to stop removing): ");
            foreach (int elementToRemove in elementsToRemoveInt)
            {
                if (largeIntDataCollection.RemoveElement(elementToRemove))
                {
                    Console.WriteLine($"Element {elementToRemove} removed successfully.");
                }
                else
                {
                    Console.WriteLine($"Element {elementToRemove} not found in the collection.");
                }
            }

            Console.WriteLine("\nCollection contents after adding and removing integer elements:");
            for (int i = 0; i < initialIntData.Count; i++)
            {
                Console.WriteLine(largeIntDataCollection.GetElement(i));
            }
            Console.ReadKey();
        }
    }

    
    private static List<T> GetDataFromUser<T>(string message)
    {
        List<T> data = new List<T>();
        Console.WriteLine(message);

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
                break;

            if (typeof(T) == typeof(string))
            {
                data.Add((T)Convert.ChangeType(input, typeof(T)));
            }
            else if (typeof(T) == typeof(int))
            {
                if (int.TryParse(input, out int value))
                {
                    data.Add((T)Convert.ChangeType(value, typeof(T)));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
            else
            {
                Console.WriteLine($"Unsupported data type: {typeof(T)}");
                break;
            }
        }

        return data;
    }
}
