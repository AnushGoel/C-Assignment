/*
 * Name: Anush Goel
 * Batch: Summer Intake (2024)
 * Purpose: To Build Loan Calcuator
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment4_AnushGoel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number;
            string user;
            Write("Enter the number");
            user = ReadLine();
            number = int.Parse(user);

            Console.WriteLine(number);

            double cube;
            double square;
            Get(number, out cube, out square);


            double loanAmount = GetUserInput("Loan Amount: \t\t\t");
            double rate = GetUserInput("Interest Rate: \t\t\t");
            double years = GetUserInput("Number of years for loan: \t");
            double numPayment = years * 12;
            double monthlyInterestRate = rate / 12;
            double term = Math.Pow(1 + monthlyInterestRate, numPayment);
            double paymentAmount = MonthlyPayment(loanAmount,rate,years, monthlyInterestRate, numPayment, term);

            DisplayBanner(loanAmount, rate, years, monthlyInterestRate,numPayment, paymentAmount);
        }


        static public void Get(int number, out double cube, out double square)
        {
            cube = Math.Pow(number, 3);
            square = Math.Pow(number, 2);

            WriteLine($"Write cube {cube:f2}");
            WriteLine($"Write Square{square:f2}");
        }

        // First method for Get user input using Tryparse
        static public double GetUserInput(string message)
        {
            double userInput;
            while (true)
            {
                Write(message + " ");
                string input = ReadLine();

                if (double.TryParse(input, out userInput) && userInput > 0 == true)
                    break;
                else
                {
                    WriteLine("Error: Please enter correct value");
                }
            }
            return userInput;
        }

        // Second Method For Calcuations of Monthly Payment.
        static public double MonthlyPayment(double loanAmount, double rate, double years, double monthlyInterestRate, double numPayment, double term)
        {
            double monthlyPayment = loanAmount * monthlyInterestRate * term / (term - 1);
            return monthlyPayment;
        }
        
        // Last method using loops to create dispaly banner
        static public void DisplayBanner(double loanAmount, double rate, double years, double monthlyInterestRate, double numPayment, double paymentAmount)
        {
            WriteLine($"Monthy Payment: {paymentAmount:c2}");
            WriteLine("\n Month \t\t Int.\t\tPrinc.\t\tNew");
            WriteLine(" No. \t\t Pd.\t\tPd.\t\tBalance");
            WriteLine("------- \t------\t\t------\t\t----------");
            

            double balance = loanAmount;
            for (int month = 1; month <= numPayment; month++)
            {
                double interest = monthlyInterestRate*balance;
                double principal = paymentAmount - interest;
                balance = balance - principal;

                WriteLine($"{month}\t\t{interest:c2}\t\t{principal:c2}\t\t{balance:c2}");
            }
            WriteLine($"\nPayment Amount: {paymentAmount:c2}");

            // Total Interest Paid using by calacuating the total amount paid minus loan amount.
            double totalInterestPaid = (paymentAmount * numPayment) - loanAmount;
            WriteLine($"Interest paid over life of loan: {totalInterestPaid:c2}");

            // Used to loop the calculator 
            Write("\nDo another calculations <Y or N>): ");
            string input = ReadLine();
            if (input == "y" || input == "Y")
            {
                Clear();  // Used to clear previous calacuations
                Main(null);
            }
            else
            {
                WriteLine("Exit the program");
            }
            
            ReadKey();
        }
    }
}