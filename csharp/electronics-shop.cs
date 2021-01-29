using System;

class Solution
{
  static int GetMoneySpent(int[] keyboards, int[] drives, int b)
  {
    int max = -1;
    for (int i = 0; i < keyboards.Length; i++)
    {
      for (int j = 0; j < drives.Length; j++)
      {
        if (keyboards[i] + drives[j] <= b)
        {
          int temp = keyboards[i] + drives[j];
          max = temp > max ? temp : max;
        }
      }
    }

    return max;
  }

  static void Main(string[] args)
  {    
    string[] bnm = Console.ReadLine().Split(' ');
    int b = Convert.ToInt32(bnm[0]);
    int n = Convert.ToInt32(bnm[1]);
    int m = Convert.ToInt32(bnm[2]);
    int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
    int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));
    int moneySpent = GetMoneySpent(keyboards, drives, b);
    Console.WriteLine(moneySpent);
  }
}
