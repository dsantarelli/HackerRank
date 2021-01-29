using System;
class Solution
{

  static void Main(string[] args)
  {
    int n = Convert.ToInt32(Console.ReadLine());
    string[] scores_temp = Console.ReadLine().Split(' ');
    int[] scores = Array.ConvertAll(scores_temp, int.Parse);
    int m = Convert.ToInt32(Console.ReadLine());
    string[] alice_temp = Console.ReadLine().Split(' ');
    int[] alice = Array.ConvertAll(alice_temp, int.Parse);

    int[] rank = new int[n];
    rank[0] = 1;
    for (int i = 1; i < n; i++)
      if (scores[i] == scores[i - 1]) rank[i] = rank[i - 1];
      else rank[i] = rank[i - 1] + 1;

    for (int i = 0; i < m; i++)
    {
      int index = BinarySearch(scores, alice[i]);
      if (alice[i] >= scores[index]) Console.WriteLine(rank[index]);
      else Console.WriteLine(rank[index] + 1);
    }

  }

  static int BinarySearch(int[] scores, int aliceValue)
  {
    int left = 0;
    int right = scores.Length - 1;

    while (left < right)
    {
      int middle = (left + right) / 2;
      if (scores[middle] == aliceValue) return middle;
      else if (scores[middle] < aliceValue) right = middle - 1;
      else left = middle + 1;
    }

    return left;
  }
}
