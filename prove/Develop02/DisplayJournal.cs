using System;
public class DisplayJournal
{

    int _entryResponse;
    public DateTime _dateTareek;

    public List<string> _questions;


    public Dictionary<string, string> _responses;


    public DisplayJournal()
    {
        _dateTareek = DateTime.Now;
        _questions = new List<string>();
        _responses = new Dictionary<string, string>();
    }

    public void AdditionToTheList()
    {
        _questions.Add("Who was the most interesting person you interacted today?");
        _questions.Add("What was the best part of your day?");
        _questions.Add("How did you see the hand of the Lord in your life today?");
        _questions.Add("Write about the strongest emotion you felt today?");
        _questions.Add("If you had one thing, you could do today, what would that be?");
    }

    public void AskQuestions()
    {
        while(_entryResponse != 1)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            string _userResponse = Console.ReadLine();
            _entryResponse = int.Parse(_userResponse);

            if (_entryResponse == 1)
            {
                foreach(string _question in _questions)
                {
                    Console.WriteLine(_question);
                    string _response = Console.ReadLine();
                    Console.WriteLine(_response);
                    _responses.Add(_response, _question);
                }
            }

        }

    }

    public void DisplayPromptResponses()
    {
       AskQuestions();
       while (_entryResponse != 2)
       {
            Console.WriteLine("Welcome!");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            string userResponse = Console.ReadLine();
            _entryResponse  = int.Parse(userResponse);

            foreach(var pair in _responses)
            {
                Console.WriteLine($"Date: {_dateTareek} - Prompt: {pair.Value}");
                Console.WriteLine($"{pair.Key}");



            }
       }
        
    }
}