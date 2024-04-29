using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage:");
        string grade_percentage = Console.ReadLine();
        int int_conversion = int.Parse(grade_percentage);

        string letter = "";

        if (int_conversion >= 90)
        {
            letter = "A";
        }
        else if (int_conversion >= 80)
        {
            letter = "B";    
        }
        else if (int_conversion >= 70)
        {
            letter = "C";      
        }
        else if (int_conversion >= 60)
        {
            letter = "D";     
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        if (int_conversion >= 70)
        {
           Console.WriteLine("Congratulations! You have passed the course.");
        }
        else
        {
           Console.WriteLine("We are so sorry.");
           Console.WriteLine("You should get at least 70% to pass this course.");
        }
    }

}