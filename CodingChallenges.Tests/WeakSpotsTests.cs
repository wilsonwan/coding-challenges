using NUnit.Framework;
using CodingChallenges.Library;
using System.Collections.Generic;

namespace CodingChallenges.Tests
{
    public class WeakSpotsTests
    {
        public WeakSpots WeakSpots;

        [SetUp]
        public void Setup()
        {
            WeakSpots = new WeakSpots();
        }

        [Test]
        public void CalculateHighestScoresWith4By4Square()
        {
            var result = WeakSpots.CalculateHighestScores(2, 4, new List<int> { 4, 2, 3, 2, 0, 1, 2, 2, 1, 3, 0, 2, 2, 0, 1, 5 });

            Assert.AreEqual("(2,1,17)(1,1,16)", result);
        }

        [Test]
        public void CalculateHighestScoresWith2By2Sqaure()
        {
            var result = WeakSpots.CalculateHighestScores(2, 2, new List<int> { 3, 4, 5, 6 });

            Assert.AreEqual("(0,0,18)(1,0,18)", result);
        }
    }
}