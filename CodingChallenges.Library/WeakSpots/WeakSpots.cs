using System.Collections.Generic;
using System.Linq;

namespace CodingChallenges.Library
{
    public class WeakSpots
    {
        public string CalculateHighestScores(int countOfHighScores, int rowLength, List<int> array)
        {
            var highestScores = new List<ScoreObject>();
            var highestScoresString = string.Empty;
            var processedArray = new int[rowLength, rowLength];

            // Convert array to 2d array
            for (int row = 0; row < rowLength; row++)
            {
                for (int column = 0; column < rowLength; column++)
                {
                    processedArray[column, row] = array.First();
                    array.RemoveAt(0);
                }
            }

            // Calculate highest scores
            for (int row = 0; row < rowLength; row++)
            {
                for (int column = 0; column < rowLength; column++)
                {
                    var newScore = TraverseArray(column, row, processedArray);

                    highestScores.Add(new ScoreObject
                    {
                        X = column,
                        Y = row,
                        Score = newScore
                    });
                }
            }

            // Prefer highest score then locataions that are topmost and then, if necessary, leftmost
            var sortedList = highestScores.OrderByDescending(x => x.Score).ThenBy(y => y.Y).ThenBy(z => z.X).Take(countOfHighScores);

            foreach (var item in sortedList)
            {
                highestScoresString += $"({item.X},{item.Y},{item.Score})";
            }

            return highestScoresString;
        }

        private int TraverseArray(int xPosition, int yPosition, int[,] processedArray)
        {
            var sum = 0;

            for (int row = -1; row <= 1; row++)
            {
                for (int column = -1; column <= 1; column++)
                {
                    try
                    {
                        sum += processedArray[xPosition + column, yPosition + row];
                    }
                    catch
                    {
                        // Ignore out of bound traversal
                    }
                }
            }

            return sum;
        }
    }

    internal class ScoreObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Score { get; set; }
    }
}