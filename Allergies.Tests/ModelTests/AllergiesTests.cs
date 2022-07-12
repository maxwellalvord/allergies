using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Allergies;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergyTests
  {
    [TestMethod]
    public void Allergy_createAllergyObjWithScoreOne_One()
    {
      //arrange
      // any necessary logic to prep for test; instantiating new classes, etc.
      Allergy newscore = new Allergy(1);

      //act
      
      //assert
      
      Assert.AreEqual(1, newscore.Score);
    }

    [TestMethod]
    public void Allergy_CalculateAllergyForOne_Eggs()
    {
      int score = 1;
      Allergy newscore = new Allergy(score);
      List<string> correctAnswer = new List<string> {"eggs"};
      Assert.AreEqual(correctAnswer[0], newscore.CalculateAllergies()[0]);
    }

    [TestMethod]
    public void Allergy_CalculateAllergyForTwo_EggsPeanuts()
    {
      int score = 3;
      Allergy newscore = new Allergy(score);
      List<string> correctAnswer = new List<string> {"eggs", "peanuts"};
      Assert.AreEqual(correctAnswer[0], newscore.CalculateAllergies()[0]);
      Assert.AreEqual(correctAnswer[1], newscore.CalculateAllergies()[1]);
    }
  }
}