using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            double sum = x / y;
            if(y == 0)
            {
                throw new ArgumentOutOfRangeException("Cannot divide by zero kunucklehead");
            }
            return sum;
        }

        static int CheckFileExtension(string fileName)
        {
            int points = 0;
                      
           
           if(fileName == null || fileName == ""){
                throw new Exception("Your filename cannot be null or an empty string");
            }

            if (fileName.Substring(fileName.Length-3, 3) == ".cs")
            {
                points++;
            }
            
            return points;

        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!


            try
            {
                Console.WriteLine(Divide(10, 0));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            students.Add("Brad", "");
            students.Add("George", "program.ps");
            
            foreach (var file in students)
            {
               int points = 0;
                try
                {
                    points += CheckFileExtension(file.Value);
                    Console.WriteLine($"{file.Key} has earned {points} points for {file.Value}");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               
            }

           

        }
    }
}
