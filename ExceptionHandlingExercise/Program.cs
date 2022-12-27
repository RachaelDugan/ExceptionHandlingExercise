using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            char[] arr = { 'a', 'b', 'c', '1', '2', '3', '4', '5', '6' }; // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            List<int> numbers = new List<int>();  // Create a list called numbers that will hold integers
            string str = ""; // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------

            //TODO START HERE:
            // Make a foreach loop to iterate through your character array
            foreach (char character in arr)  //character will be the name of each item in your collection
            {
                try  // Now create a try catch
                {                                     // Inside your try block
                    str = character.ToString();       // set your string variable to each array element in your char[] to .ToString()
                    int num = int.Parse(str);         // Now, using int.Parse, parse your string variable and store in an int variable
                    numbers.Add(num);                 // Then add each int to your list
                }
                catch (Exception ex)                 // catch your Exception:
                                                     // in the scope of your catch you can use the following, 
                {                                   //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
                    Console.WriteLine($"Unable to Parse '{character}'"); 
                    //Console.WriteLine(ex.Message);
                    //Console.WriteLine(ex.GetType());
                    //Console.WriteLine ("Byyyeee");
                    //Console.WriteLine();
                } 
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }



















        }
    }
}
