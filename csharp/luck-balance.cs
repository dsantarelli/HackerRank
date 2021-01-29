using System.Collections.Generic;
using System;

class Solution
{  
  static int LuckBalance(int k, int[][] contests)
  {
    int totalLuckBalance = 0;
    int impContestCount = 0;
    List<int> tempList = new List<int>();

    for (int i = 0; i < contests.Length; i++)
    {
      if (contests[i][1] == 0)
        totalLuckBalance += contests[i][0];
      else
      {
        impContestCount++;
        tempList.Add(contests[i][0]);
        totalLuckBalance += contests[i][0];
      }
    }

    if (impContestCount > k)
    {
      tempList.Sort();
      int n = impContestCount - k;
      for (int j = 0; j < n; j++)
      {
        totalLuckBalance -= 2 * tempList[j];
      }
    }

    return totalLuckBalance;
  }

  static void Main(string[] args)
  {    
    string[] nk = Console.ReadLine().Split(' ');
    int n = Convert.ToInt32(nk[0]);
    int k = Convert.ToInt32(nk[1]);
    int[][] contests = new int[n][];

    for (int i = 0; i < n; i++)   
      contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));    

    int result = LuckBalance(k, contests);
    Console.WriteLine(result);
  }
}
