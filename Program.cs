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

        Console.WriteLine("What is your name?");     // this is the input
        string firstName = Console.ReadLine();    // this allows users output
        Console.WriteLine($"Hello {firstName}");  // this states the answer correctly

        // adding two lines of space between each coding helps the computer read it efficiently and with time.

        Console.WriteLine("What about a middle name?");
        string middleName = Console.ReadLine();
        Console.WriteLine($"Hello {firstName} {middleName}");

        // I asked the above statement an option because I do not have a middle name!

        Console.WriteLine(" What is your last name?");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Hello {firstName} {middleName} {lastName}");

        // i asked for the age of this year because although I am 21 it would have gotten my year incorrectly

        Console.WriteLine("How old are you this year in 2023?");
        string inputAge = Console.ReadLine();
        int yearBorn = 2023 - Convert.ToInt32(inputAge);


        Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");
        // this is so cool i got it to work.

      
        // math operations now
        Console.WriteLine("Math Section");



        // changed the coding so the user now has authority to pick any integer
        // convertede string to int allowing any number to follow the math operations.
        Console.WriteLine("Please enter a number!");
        string integerText = Console.ReadLine();
        int integer1 = Convert.ToInt32(integerText);
        Console.WriteLine(integer1);

        Console.WriteLine("Now please choose a second number!");
        string integerText2 = Console.ReadLine();
        int integer2 = Convert.ToInt32(integerText2);
        Console.WriteLine(integer2);

        // this is the formular for the operations
        Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
        Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
        Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
        Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
        Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");

        Console.ReadLine();


        // I added readline after the section to give the user the authority
        //when needed to read the equations correctly

        Console.WriteLine("Circle Area");

        
        Console.WriteLine($" Enter radius: "); // this allows input for the reader
        double Radius = Convert.ToDouble(Console.ReadLine());
        double Area = Math.PI * Math.Pow(Radius, 2);  // lines 74-77 are the formula's
        Console.WriteLine($"Area of circle: " + Area);
        double circumference = 2 * Math.PI * Radius;
        Console.WriteLine($"Circumference of circle: " + circumference);
        Console.ReadKey(); // this helps with the output being completed
        Console.WriteLine("Hello, World!");
    }
}

