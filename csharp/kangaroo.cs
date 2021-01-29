using System;

class Solution
{
  private const string YES = "YES";
  private const string NO = "NO";

  static string kangaroo(int x1, int v1, int x2, int v2)
  {
    if ((x2 > x1 && v2 > v1) || (x1 > x2 && v1 > v2))
      return NO;

    long k1 = x1;
    long k2 = x2;
    var jumps = 0;

    while (jumps < int.MaxValue)
    {
      if (k1 == k2) return YES;
      k1 += v1;
      k2 += v2;
      ++jumps;
    }

    return NO;
  }

  static void Main(string[] args)
  {
    string[] x1V1X2V2 = Console.ReadLine().Split(' ');
    int x1 = Convert.ToInt32(x1V1X2V2[0]);
    int v1 = Convert.ToInt32(x1V1X2V2[1]);
    int x2 = Convert.ToInt32(x1V1X2V2[2]);
    int v2 = Convert.ToInt32(x1V1X2V2[3]);
    string result = kangaroo(x1, v1, x2, v2);
    Console.WriteLine(result);
  }
}
