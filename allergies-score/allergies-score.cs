using System;

namespace AllergiesScore
{
  class AllergyScore
  {
    static void Main()
    {
      Score userScore = new Score();
      Console.WriteLine("Please Enter your Allergy Score:");
      string userScoreString = Console.ReadLine();
      int userScoreInt = 0;
      try
      {
        userScoreInt = Int32.Parse(userScoreString);
        string[] userAllergies = userScore.ListAllergies(userScoreInt);
        Console.WriteLine("You're Allergic to:");
        foreach(var item in userAllergies)
      {
        Console.WriteLine(item.ToString());
      }
      }
      catch (FormatException)
      {
        Console.WriteLine($"{userScoreString} is not an integer, please try again");
        Main();
      }
    }
  }
}