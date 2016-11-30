using Xunit;
using System;
using System.Collections.Generic;
using Allergies.Objects;

namespace Allergies
{
    public class AllergiesTest
    {
      [Fact]
      public void AllergyTest_CheckAllergies_true()
      {
        int allergyScore = 74;
        Allergy newAllergy = new Allergy(allergyScore);
        List<string> result = newAllergy.CheckAllergies();
        List<string> testList = new List<string> {"pollen", "strawberries", "peanuts"};
        Assert.Equal(true, result == testList);
      }

    }
}
