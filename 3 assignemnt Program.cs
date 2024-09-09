/*
Programmer: ANUSH GOEL
Date: MAY INTAKE(2024) (03 - 06 - 2024)
Purpose: TO LEARN NEW ABOUT METHODS (CREATIONS AND USUAGE)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace A3_AnushGoel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float ASSIGNMENTS_PERCENTAGE = 0.1f;
            const float QUIZZES_PERCENTAGE = 0.2f;
            const float MIDTERM_PERCENTAGE = 0.3f;
            const float FINALTERM_PERCENTAGE = 0.4f;
            const float TOTAL_PERCENTAGE = ASSIGNMENTS_PERCENTAGE + QUIZZES_PERCENTAGE + MIDTERM_PERCENTAGE
                + FINALTERM_PERCENTAGE;

            float assignment = GetUserInput("assignment");
            float quiz1 = GetUserInput("quiz1");
            float quiz2 = GetUserInput("quiz2");
            float midterm = GetUserInput("midterm");
            float final = GetUserInput("final");

            DisplayBanner();
            DisplayTableRow("Assessment", "Percentage", "YourGrade");
            DisplayTableRow("Assigment", ASSIGNMENTS_PERCENTAGE, assignment);
            DisplayTableRow("Quiz1", QUIZZES_PERCENTAGE / 2, quiz1);
            DisplayTableRow("Quiz2", QUIZZES_PERCENTAGE / 2, quiz2);
            DisplayTableRow("Midterm", MIDTERM_PERCENTAGE, midterm);
            DisplayTableRow("Finalterm", FINALTERM_PERCENTAGE, final);

            WeightedGrade(assignment, quiz1, quiz2, midterm, final, TOTAL_PERCENTAGE, ASSIGNMENTS_PERCENTAGE,
                QUIZZES_PERCENTAGE, MIDTERM_PERCENTAGE, FINALTERM_PERCENTAGE);

        }
        //method for grades input
        public static float GetUserInput(string textMessage)
        {
            string inputvalue;
            Write("Enter the marks of {0}:" + "\t", textMessage);
            inputvalue = ReadLine();
            float marks_total = float.Parse(inputvalue);
            return marks_total;

        }
        //method for displaying banner
        public static void DisplayBanner()
        {
            Write("\n");
            Write("\\***********************************************\\ \n");
            Write("\\ \t\t\t\t\t\t\\\n");
            Write("\\\t\"Total Weighted Average Calculator\"\t\\ \n");
            Write("\\ \t\t\t\t\t\t\\\n");
            Write("\\***********************************************\\ \n\n\n");
        }

        // Method for displaying First Rows of banner
        public static void DisplayTableRow(string name, string value, string marks)
        {
            WriteLine("{0,14}{1,13:P0}  {2,-15}", name, value, marks);
            WriteLine(" -------------   ----------  --------- ");
        }
        //method for displaying rest rows (assesment,percentage and grade value)
        public static void DisplayTableRow(string assesment, float percentage, float grade)
        {
            WriteLine("{0,14}{1,13:P0}  {2,-15}", assesment, percentage, grade);
        }

        // method for Weighted Grade Formula (Inculdes Assignment)
        public static void WeightedGrade(float assignment, float quiz1, float quiz2, float midterm, float final, float TOTAL_PERCENTAGE,
            float ASSIGNMENTS_PERCENTAGE, float QUIZZES_PERCENTAGE, float MIDTERM_PERCENTAGE, float FINALTERM_PERCENTAGE)
        {
            float weightedGrade = (assignment * ASSIGNMENTS_PERCENTAGE) +
                                   ((quiz1 + quiz2) / 2 * QUIZZES_PERCENTAGE) +
                                   (midterm * MIDTERM_PERCENTAGE) +
                                   (final * FINALTERM_PERCENTAGE);
            WriteLine(" -------------   ----------  --------- ");
            WriteLine("{0,14}{1,13:P0}  {2,-15}", "WeightedGrade", TOTAL_PERCENTAGE, weightedGrade);

            //weighted total without including assignment percentage

            float weight_total_1 = (((quiz1 + quiz2) * QUIZZES_PERCENTAGE / 2 + midterm * MIDTERM_PERCENTAGE + final * FINALTERM_PERCENTAGE))
                / (QUIZZES_PERCENTAGE + MIDTERM_PERCENTAGE + FINALTERM_PERCENTAGE);

            // Dispalying Left Rows
            WriteLine("\n");
            WriteLine("\nThe Weighted Average Total on Exams (Midterm, Quizzes, Final exam) is {0:F2}", weight_total_1);
            WriteLine("If WAT-on-Exam is less than 50, the student fails the course.");
            ReadKey();
        }
    }
}