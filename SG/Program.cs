using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfStudent = 1;
            int[] ScoreMin, Scorefinal, Scoresum;
            string[] Namestudent;

            // Firstly, The program ask the user about student quantity.
            Console.Write("How many students? : ");
            quantityOfStudent = int.Parse(Console.ReadLine()); // Convert 'string' from Console.ReadLine() to 'int'.

            // Secondly, re-allocating array sizing.
            Namestudent = new string[quantityOfStudent];
            ScoreMin = new int[quantityOfStudent];
            Scorefinal = new int[quantityOfStudent];
            Scoresum = new int[quantityOfStudent];

            // Thirdly, The user key each student information.
            Console.WriteLine(":: Student Information ::");
            for (int iterator = 0; iterator < quantityOfStudent; iterator++)
            {
                // User feild student name, middle and final score information.
                Console.Write($"\nPlease key student({iterator + 1} of {quantityOfStudent}) name : ");
                Namestudent[iterator] = Console.ReadLine();

                Console.Write($"Please key {Namestudent[iterator]}'s middle score : ");
                ScoreMin[iterator] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Please key {Namestudent[iterator]}'s final score : ");
                Scorefinal[iterator] = Convert.ToInt32(Console.ReadLine());

                // Score summation 
                Scoresum[iterator] = ScoreMin[iterator] + Scorefinal[iterator];
            }

            // Fourthly, We have to grades processing from each people's 'sumScore[]'. 
            Console.WriteLine("\n:: List of students and grades ::");
            int _students = 0;

            do
            {
                float ScoreGrades = 0.0f;   // This is the local variables in 'do..while' statement.

                #region Writng an if..else..if code without curly brackets type 1. 

                // For example, we use this region as defualt code.
                if (Scoresum[_students] <= 49) ScoreGrades = 0f;
                else if (Scoresum[_students] <= 54) ScoreGrades = 1f;
                else if (Scoresum[_students] <= 59) ScoreGrades = 1.5f;
                else if (Scoresum[_students] <= 64) ScoreGrades = 2f;
                else if (Scoresum[_students] <= 69) ScoreGrades = 2.5f;
                else if (Scoresum[_students] <= 74) ScoreGrades = 3f;
                else if (Scoresum[_students] <= 79) ScoreGrades = 3.5f;
                else if (Scoresum[_students] >= 80) ScoreGrades = 4f;

                #endregion



                Console.WriteLine($"{_students + 1}. {Namestudent[_students]} have a" +
                                $" total {Scoresum[_students]} score or {ScoreGrades} grades.");
                _students++;
            } while (_students < quantityOfStudent);

            Console.Write("\nPress any key enter....");
            Console.ReadLine();
        }
    }
}