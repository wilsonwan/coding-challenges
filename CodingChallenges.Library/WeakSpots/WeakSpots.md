# WeakSpots

We have a square grid of values ranging from 0 to 5, We want to calculate a score for each location in the grid. The score is determined by adding each location's own value, to the values of all surrounding locations.

You will be assessed on the readability and robustness of your solution given various inputs. The performance of the solution is not being assessed.

For example, for grid numbers such as this:
4 | 2 | 3 | 2
0 | 1 | 2 | 2
1 | 3 | 0 | 2
2 | 0 | 1 | 5

The score for location (1,1) is calculated by summing the numbers in blod in and around (1,1) as follows:
**4** | **2** | **3** | 2
**0** | **1** | **2** | 2
**1** | **3** | **0** | 2
2 | 0 | 1 | 5

score(1, 1) = 4 + 2 + 3 + 0 + 1 + 2 + 1 + 3 + 0 = 16

When dealing with locations around the edge of the grid, the score should ignore values outside the grid. For instance the score of location (0,0) is as follows:
**4** | **2** | 3 | 2
**0** | **1** | 2 | 2
1 | 3 | 0 | 2
2 | 0 | 1 | 5

score(0,0) = 4 + 2 + 0 + 1 = **7**
Write a function:

```CalculateHighestScores(countOfHighestScores, rowLength, array)```

that, given an integer **countOfHighScore**, an integer **rowLength** and a zero-indexed array **array** consisting of **rowLength*rowLength** integers, returns a list of the **countOfHighScores** highest scores and their locations.

Each location and score should be formatted as follows:
"(x,y,score)"
Where (x,y) is the zero-indexed vector from the top-left of the grid.
The list should be returned as a string:
"(x1,y1,score1)(x2,y2,score2)(x3,y3,score3)"
If there are multiple locations with the same score, prefer locataions that are topmost and then, if necessary, leftmost, e.g. "(1,0,20)(3,0,20)(1,1,20)"

For example, the function inputs asking for the top 2 score in the grid below would be as follows:
4 | 2 | 3 | 2
0 | 1 | 2 | 2
1 | 3 | 0 | 2
2 | 0 | 1 | 5

Would be:
**countOfHighScore** = 2
**rowLength** = 4
**array** = [4,2,3,2,0,1,2,2,1,3,0,2,2,0,1,5]

The expected result would be:
"(2,1,17)(1,1,16)"

You can choose to test your code with custom input below. HackerRank requires you to specify your input as newline separated values; arrays must consist of the length of the array on the first line, followed by the elements of the array.

e.g.
**countOfHighScores** = 2
**rowLength** = 2
**array** = [3,4,5,6]