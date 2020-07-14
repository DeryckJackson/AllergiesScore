using System;
using System.Collections.Generic;

namespace AllergiesScore
{
  public class Score
  {
    public string[] ListAllergies(int score)
    {
      List<string> list = new List<string>();
      if(score > 255)
      {
        score = 255;
      }
      if(score <= 0)
      {
        list.Add("-no allergies-");
      }
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
        score -= 16;
      }
      if(score >= 8)
      {
        list.Add("strawberries");
        score -= 8;
      }
      if(score >= 4)
      {
        list.Add("shellfish");
        score -= 4;
      }
      if(score >= 2)
      {
        list.Add("peanuts");
        score -= 2;
      }
      if(score == 1)
      {
        list.Add("eggs");
        score -= 1;
      }

      string[] output = list.ToArray();
      return output;
    }
  }
}