﻿using System;

namespace _04._Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int count5 = 0;
            int count4 = 0;
            int count3 = 0;
            int count2 = 0;
            double totalGrade = 0;
            for (int i = 1; i <= students; i++)
            {
                double gradeStudent = double.Parse(Console.ReadLine());

                totalGrade += gradeStudent;

                if (gradeStudent >= 5)
                {
                    count5++;
                }
                else if (gradeStudent >= 4 && gradeStudent <= 4.99)
                {
                    count4++;
                }
                else if (gradeStudent >= 3 && gradeStudent <= 3.99)
                {
                    count3++;
                }
                else if (gradeStudent < 3)
                {
                    count2++;
                }
            }
            double betwen45 = (count4 / (students * 1.0)) * 100; 

            double topStudents = (count5 / (students * 1.0)) * 100;
            
            double betwen3 = (count3 / (students * 1.0)) * 100;
            double betwen2 = (count2 / (students * 1.0)) * 100;
            double sumGrade = totalGrade / students;

            Console.WriteLine($"Top students: {topStudents:F2}%"); 

            Console.WriteLine($"Between 4.00 and 4.99: {betwen45:F2}%");

            Console.WriteLine($"Between 3.00 and 3.99: {betwen3:F2}%");

            Console.WriteLine($"Fail: {betwen2:F2}%");

            Console.WriteLine($"Average: {sumGrade:F2}");
        }
    }
}