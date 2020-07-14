using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllergiesScore;

namespace AllergiesScore.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void ListAllergies_InputNumberIncludesCatsScore_Cats()
    {
      Score testScore = new Score();
      string[] expected = {"cats"};
      CollectionAssert.AreEqual(expected, testScore.ListAllergies(128));
    }

    [TestMethod]
    public void ListAllergies_InputNumberIncludesPollenScore_pollen()
    {
      Score testScore = new Score();
      string[] expected = {"pollen"};
      CollectionAssert.AreEqual(expected, testScore.ListAllergies(64));
    }
  }
}