using System;

public class DisplayJournal
{
    public DateTime _dateTareek = DateTime.Now ;

    List<string> _questions = new List<string>();
    _questions.Add("Who was the most interesting person you interacted today?");
    _questions.Add("What was the best part of your day?");
    _questions.Add("How did you see the hand of the Lord in your life today?");
    _questions.Add("Write about the strongest emotion you felt today?");
    _questions.Add("If you had one thing, you could do today, what would that be?");

    public void AskQuestion()
    {

        for each (string _promptRespone in _questions)
        {
           Console.WriteLine(_questions);
           _promptResponse = Console.ReadLine(_questions);

           
        }
    }

    public void DisplayPromptResponses()
    {

    }
}
