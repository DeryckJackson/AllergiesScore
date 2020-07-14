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
      int userScoreInt = Int32.Parse(userScoreString);
      string[] userAllergies = userScore.ListAllergies(userScoreInt);
      Console.WriteLine("You're Allergic to:");
      foreach(var item in userAllergies)
      {
        Console.WriteLine(item.ToString());
      }
    }
  }
}