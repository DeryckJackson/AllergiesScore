using System;
using System.Collections.Generic;

namespace AllergiesScore
{
  public class Score
  {
    public string[] ListAllergies(int score)
    {
      List<string> list = new List<string>();
      if(score >= 128)
      {
        list.Add("cats");
      }

      string[] output = list.ToArray();
      return output;
    }
  }
}