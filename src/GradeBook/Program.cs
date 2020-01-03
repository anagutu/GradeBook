using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ana's Grade Book");
            book.AddGrade(20.3);
            book.AddGrade(30.4);
            book.AddGrade(40.5);

            var stats = book.GetStatistics();

            System.Console.WriteLine($"The average grade is {stats.Average:N4}"); 
            System.Console.WriteLine($"The highest grade is {stats.High}");           
            System.Console.WriteLine($"The lowest grade is {stats.Low}");
            //Hello, Me!!

           
        }
    }
}
 