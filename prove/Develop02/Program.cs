using System;

class Program
{
    static void Main(string[]args)
    {
        DisplayJournal journalone = new DisplayJournal();


        SavedJournal journalek = new SavedJournal();

        int _entryResponse = -1; 

        Console.WriteLine("Welcome!");
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Exit");
        string _userResponse = Console.ReadLine();
        _entryResponse = int.Parse(_userResponse);


        while (_entryResponse == 5)
        {
            Console.WriteLine("Thanks for using the app.");
            Console.WriteLine("We would love to see you back.");
            Console.WriteLine("Hope you have great upcoming days :)");

            if (_entryResponse == 1 )
            {
                journalone.AskQuestions();
            }
            else if (_entryResponse == 2)
            {
                journalone.DisplayPromptResponses();
            }
            else if (_entryResponse == 3)
            {
                journalek.SaveFileName();
            }

            else if (_entryResponse == 4)
            {
                journalek.LoadTheFile();
            }

            else if (_entryResponse == 5)
            {
                Console.WriteLine("Thanks for using the app.");
                Console.WriteLine("We would love to see you back.");
                Console.WriteLine("Hope you have great upcoming days :)");
            }

        }

    }
}