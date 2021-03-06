using Microsoft.VisualStudio.TestTools.UnitTesting;

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

    [TestMethod]
    public void ListAllergies_InputNumberIncludesChocolateScore_chocolate()
    {
      Score testScore = new Score();
      string[] expected = {"chocolate"};
      CollectionAssert.AreEqual(expected, testScore.ListAllergies(32));
    }

    [TestMethod]
    public void ListAllergies_InputNumberIncludestomatesScore_tomatoes()
    {
      Score testScore = new Score();
      string[] expected = {"tomatoes"};
      CollectionAssert.AreEqual(expected, testScore.ListAllergies(16));
    }

    [TestMethod]
    public void ListAllergies_InputNumberIncludesStrawberriesScore_strawberries()
    {
      Score testScore = new Score();
      string[] expected = {"strawberries"};
      CollectionAssert.AreEqual(expected, testScore.ListAllergies(8));
    }

    [TestMethod]
    public void ListAllergies_InputNumberIncludesShellfishScore_shellfish()
    {
      Score testScore = new Score();
      string[] expected = {"shellfish"};
      CollectionAssert.AreEqual(expected, testScore.ListAllergies(4));
    }

    [TestMethod]
    public void ListAllergies_InputNumberIncludesPeanutsScore_peanuts()
    {
      Score testScore = new Score();
      string[] expected = {"peanuts"};
      CollectionAssert.AreEqual(expected, testScore.ListAllergies(2));
    }

    [TestMethod]
    public void ListAllergies_InputNumberIncludeseggsScore_eggs()
    {
      Score testScore = new Score();
      string[] expected = {"eggs"};
      CollectionAssert.AreEqual(expected, testScore.ListAllergies(1));
    }

    [TestMethod]
    public void ListAllergies_InputNumberIncludesMultipleAllergies_catsTomatoesPeanuts()
    {
      Score testScore = new Score();
      string[] expected = {"cats", "tomatoes", "peanuts"};
      CollectionAssert.AreEqual(expected, testScore.ListAllergies(146));
    }
  }
}