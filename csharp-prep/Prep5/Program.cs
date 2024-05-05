using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int SquaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, SquaredNumber);
    }

   static void DisplayWelcome()
   {
    Console.WriteLine("Welcome to the Program");    
   }

   static string PromptUserName()
   {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        return userName;
   }

   static int PromptUserNumber()
   {
        Console.Write("Enter your favorite number: ");
        string favorite_number = Console.ReadLine();
        int int_conversion = int.Parse(favorite_number);
        return int_conversion;
   }

    static int SquareNumber(int favorite_number)
    {
        int squared_number = favorite_number * favorite_number;
        return squared_number;
    }

    static void DisplayResult(string user_name, int squared_number)
    {
        Console.WriteLine($"{user_name}, the square of your number is {squared_number}");

    }

}