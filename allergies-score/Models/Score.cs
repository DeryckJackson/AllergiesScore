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
        score -= 128;
      }
      if(score >= 64)
      {
        list.Add("pollen");
        score -= 64;
      }
      if(score >= 32)
      {
        list.Add("chocolate");
        score -= 32;
      }
      if(score >= 16)
      {
        list.Add("tomatoes");
        score -= 32;
      }

      string[] output = list.ToArray();
      return output;
    }
  }
}