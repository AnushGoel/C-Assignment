using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float ASSIGNMENTS_PERCENTAGE = 0.1f;
            const float QUIZ1_PERCENTAGE = 0.2f;
            const float MIDTERM_PERCENTAGE = 0.3f;
            const float FINALEXAM_PERCENTAGE = 0.4f;
            bool upperLimit;

            float total_Percent = (ASSIGNMENTS_PERCENTAGE + QUIZ1_PERCENTAGE + MIDTERM_PERCENTAGE + FINALEXAM_PERCENTAGE);
            float assignments = 100f;
            float quiz1 = 45.5f;
            float quiz2 = 90f;
            float midterm_Exam = 55f;
            float final_Exam = 65.8f;

            // totalWeightedAverage Expression
            float weighted_Average = (assignments * ASSIGNMENTS_PERCENTAGE + (quiz1 + quiz2) * QUIZ1_PERCENTAGE / 2
                + midterm_Exam * MIDTERM_PERCENTAGE + final_Exam * FINALEXAM_PERCENTAGE) / 1;

            // totalWeightedAverage Expression without assignment marks
            float weighted_Average_1 = ((quiz1 + quiz2) * QUIZ1_PERCENTAGE / 2
                + midterm_Exam * MIDTERM_PERCENTAGE + final_Exam * FINALEXAM_PERCENTAGE) / 0.9f;

            // Using Escape characters to display Banner
            Console.Write("\\************************************************\\\n");
            Console.Write("\\ \t\t\t\t\t\t \\ \n");
            Console.Write("\\  \"Total Weighted Average Calculator\" \t\t \\\n");
            Console.Write("\\ \t\t\t\t\t\t \\ \n");

            // Used @ to avoid to write two time splash
            Console.Write(@"\************************************************\");

            Console.WriteLine("\n\n{0,14}{1,13:P0}  {2,-15}", "Assessment", "Percentage", "Your Grade");
            Console.WriteLine("--------------  -----------  ---------- ");
            Console.WriteLine("{0,14}{1,13:P0}  {2,-15}", "Assignment", ASSIGNMENTS_PERCENTAGE, assignments);
            Console.WriteLine("{0,14}{1,13:P0}  {2,-15}", "Quiz1", QUIZ1_PERCENTAGE / 2, quiz1);
            Console.WriteLine("{0,14}{1,13:P0}  {2,-15}", "Quiz2", QUIZ1_PERCENTAGE / 2, quiz2);
            Console.WriteLine("{0,14}{1,13:P0}  {2,-15}", "MidTerm Exam", MIDTERM_PERCENTAGE, midterm_Exam);
            Console.WriteLine("{0,14}{1,13:P0}  {2,-15}", "Final Exam", FINALEXAM_PERCENTAGE, final_Exam);
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("{0,14}{1,13:P0}  {2,-15:F2}", "Weighted Total", total_Percent, weighted_Average);
            Console.WriteLine("\n\nThe Weighted Average Total on Exams (MidTerm, Quizzes, Final Exam is {0:F2}", weighted_Average_1);
            Console.WriteLine("If WAT-on-EXAM is less than 50, the student fails the course ");

            Console.ReadKey();
        }
    }
}
