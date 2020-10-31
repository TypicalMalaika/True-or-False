using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
     string[] questions = {"8>2", "3=5", "5>5", "9<11", "5!=8"};
     bool[] answers = {true, false, false, true, true};
     bool[] responses = new bool[questions.Length]; 

     if (responses.Length != questions.Length)
     {
       Console.WriteLine("The number of questions and responses is not equal.");
     }

     int askingIndex = 0;

     foreach (string question in questions)
     {
       string input;
       bool isBool;
       bool inputBool;
       Console.Write($"{question}\n True or false?\n");
       input = Console.ReadLine();
       isBool = Boolean.TryParse(input, out inputBool);
       while (isBool==false)
       {
         Console.WriteLine("Please respond with 'true' or 'false'.");
         input = Console.ReadLine();
         isBool = Boolean.TryParse(input, out inputBool);
       }
       responses[askingIndex] = inputBool;
       askingIndex++;
     }
     int scoringIndex = 0;
     int score = 0;
     foreach (bool answer in answers)
     {
       bool response = responses[scoringIndex];
       Console.Write(scoringIndex + 1 + ".");
       Console.WriteLine($"Input: {response} | Answer: {answer}");

       if (response == answer)
       {
         score++;
       }
       scoringIndex++;
     }  
     Console.WriteLine($"You got {score} out of {questions.Length} correct.");
    }
  }
}
