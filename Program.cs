/*
 * Author: Jan Gomez
 * Course: Comp 003A
 * Purpose: To finish assignment 2
 */
 namespace Comp003A.Assignment2_;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "COMP-003A - Assignment 2";
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        
        string firstName = Console.ReadLine();
        firstName = "Enter Your Name:";
        
        string middleName = Console.ReadLine();
        middleName = "Enter Your Middle Name:";

        
        string lastName = Console.ReadLine();
        lastName = "Enter Your Last Name:";

        string inputAge = Console.ReadLine();


        int yearBorn = 2023 - Convert.ToInt32(inputAge);

        Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");



        Console.WriteLine("Hello, World!");
    }
}

