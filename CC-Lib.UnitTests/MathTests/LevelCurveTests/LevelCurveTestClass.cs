using Microsoft.VisualStudio.TestTools.UnitTesting;
using CC_Lib.Math.Graph.Level;
using System.Collections.Generic;
using System;

namespace CC_Lib.UnitTests.MathTests.LevelCurveTests
{
    [TestClass]
    public class LevelCurveTestClass
    {
        [TestMethod]
        public void Test_LevelCurve_BuildUp()
        {
            double expected = 1014;
            LevelCurve curve = LevelCurveGenerator.CreateCurve(1, 50, 300, 1.5, 4, 8.0f);
            double expAtLevelTen = curve.GetExperienceByLevel(10);
            Assert.AreEqual(expected, expAtLevelTen);
        }

        [TestMethod]
        public void Cannot_GetExperienceWhenTheLevelIsOutOfScope_ShouldThrowArgumentOutOfRangeException()
        {
            LevelCurve curve = LevelCurveGenerator.CreateCurve(1, 50, 300, 1.5, 4, 8.0f);
            try
            {
                var t = curve.GetExperienceByLevel(1000);
            }
            catch(ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, LevelCurve.LevelCurveExceptions.LevelExceedsMaxLevelMessage);
            }
        }
    }
}
