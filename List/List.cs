using System;
using System.Collections.Generic;

public class List
{
    public static void Main(string[] args)
    {
        var numbers = new List <int>() { 3, 5, 24, 8, 1, 45, 13, 54, 15, 19 };
        numbers.Add(1);
        numbers.AddRange(new int[3] { 5, 6, 7, });
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine();
        Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
        Console.WriteLine();
        Console.WriteLine("Index of 1: " + numbers.LastIndexOf(1));
        Console.WriteLine();
        Console.WriteLine("Count: " + numbers.Count);
        Console.WriteLine();
        // <---------------------------------------------------------->
        //numbers.Remove(1);
        //this will only remove the first matching element.
        //foreach (int num in numbers)
        //{
        //    Console.WriteLine(num);
        //}
        // <------------------------------------------------------------>
        /*This will should find all matching elements, but will throw an error because we can't
        alter the list from the inside of the loop.  We need a regular for loop here.*/

        //foreach (int num in numbers)
        //{
        //    if (num == 1)
        //    {
        //        numbers.Remove(num);
        //    }
        //    else
        //        Console.WriteLine(num);
        //} 
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 1)
            {
                numbers.Remove(i);
            }
            else
            {
                Console.WriteLine(numbers[i]);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Count: " + numbers.Count);
        numbers.Clear();
        Console.WriteLine();
        Console.WriteLine("Count: " + numbers.Count);
        Console.WriteLine();
    }

}