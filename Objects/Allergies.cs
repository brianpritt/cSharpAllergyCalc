using System;
using System.Collections.Generic;

namespace Allergies.Objects
{
  public class Allergy
  {
    private int _allergyScore;
    private List<string> _possibleAllegies = new List<string> {};

    public Allergy(int AllergyScore)
    {
      _allergyScore = AllergyScore;
    }
    public List<string> CheckAllergies()
    {
      if(_allergyScore>=128)
      {
        _possibleAllegies.Add("cats");
        _allergyScore -= 128;
      }
      if(_allergyScore >= 64)
      {
        _possibleAllegies.Add("pollen");
        _allergyScore -= 64;
      }
      if(_allergyScore>=32)
      {
        _possibleAllegies.Add("chocolate");
        _allergyScore -= 32;
      }
      if(_allergyScore>=16)
      {
        _possibleAllegies.Add("tomatoes");
        _allergyScore -= 16;
      }
      if(_allergyScore>=8)
      {
        _possibleAllegies.Add("strawberries");
        _allergyScore -= 8;
      }
      if(_allergyScore>=4)
      {
        _possibleAllegies.Add("shellfish");
        _allergyScore -= 4;
      }
      if(_allergyScore>=2)
      {
        _possibleAllegies.Add("peanuts");
        _allergyScore -= 2;
      }
      if(_allergyScore>=1)
      {
        _possibleAllegies.Add("eggs");
        _allergyScore -= 1;
      }
      foreach(string allergy in _possibleAllegies)
      {
        Console.WriteLine(allergy);
      }
      return _possibleAllegies;
    }
  }
}
