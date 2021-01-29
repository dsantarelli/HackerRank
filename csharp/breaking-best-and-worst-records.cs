using System;

class Solution
{  
  static int[] breakingRecords(int[] scores)
  {
    int highestScoreCount= 0;
    int lowestScoreCount = 0;
    int highestScore = scores[0];
    int lowestScore = scores[0];

    for (int i = 1; i < scores.Length; i++)
    {
      if (scores[i] > highestScore)
      {
        highestScore = scores[i];
        ++highestScoreCount;
      }

      if (scores[i] < lowestScore)
      {
        lowestScore = scores[i];
        ++lowestScoreCount;
      }
    }

    return new[] { highestScoreCount, lowestScoreCount };
  }

  static void Main(string[] args)
  {    
    int n = Convert.ToInt32(Console.ReadLine());
    int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
    int[] result = breakingRecords(scores);
    Console.WriteLine(string.Join(" ", result));
  }
}
