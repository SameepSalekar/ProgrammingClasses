using System;

public class SavedJournal
{
    public string _nameGivenByTheUser;

    int _entryResponse;

    DisplayJournal _documents;

    Dictionary<string, string> _responses;

    Dictionary<string, Dictionary<string, string>> _stack;

    public SavedJournal()
    {
        _stack = new Dictionary<string, Dictionary<string, string>>();
        _documents = new DisplayJournal();
        _responses = new Dictionary<string, string>();

    }


    public void SaveFileName()
    {
        _documents.DisplayPromptResponses();      
        


        while(_entryResponse != 3)
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

            if(_entryResponse == 3)
            {   
             Console.WriteLine("By what name would you like to save your journal?");
             string _nameGivenByTheUser = Console.ReadLine();
             _stack.Add(_nameGivenByTheUser, _responses);
            }

        }
    }

    public void LoadTheFile()
    {
        while(_entryResponse != 4)
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

         if(_entryResponse == 4)
         {
            Console.WriteLine("What file would you like to upload?");
            string _requestedFile = Console.ReadLine();

            if (_requestedFile == _nameGivenByTheUser)
            {
                Console.WriteLine(_stack);
            }
            else
            {
                Console.WriteLine("The requested file do not exists in the system.");
            }


         }

        }   
    }
}