using System;

class Program
{
    static void Main(string[]args)
    {
        DisplayJournal journalone = new DisplayJournal();
        journalone._questions.Add("Who was the most interesting person you interacted today?");
        journalone._questions.Add("What was the best part of your day?");
        journalone._questions.Add("How did you see the hand of the Lord in your life today?");
        journalone._questions.Add("Write about the strongest emotion you felt today?");
        journalone._questions.Add("If you had one thing, you could do today, what would that be?");


        SavedJournal journalek = new SavedJournal();

        _entryResponse = -1

        while (_entryResponse > 5)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("What would you like to do today?")
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            _entryResponse = (int.Parse(Console.ReadLine));

            if (_entryResponse == 1 )
            {
                journalone.AskQuestion();
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

            else (_entryResponse == 5)
            {
                Console.WriteLine("Thanks for using the app.");
                Console.WriteLine("We would love to see you back.")
                Console.WriteLine("Hope you have great upcoming days :)");
            }




        }



        DisplayJournal journalone = new DisplayJournal();
        

        SavedJournal journalek = new SavedJournal();


    }
}