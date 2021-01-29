using System;

class Solution
{
  static int PageCount(int n, int p)
  {
    int lastLetter = n / 2;
    int goalLetter = p / 2;
    return Math.Min(goalLetter, lastLetter - goalLetter);
  }

  static void Main(string[] args)
  {    
    int n = Convert.ToInt32(Console.ReadLine());
    int p = Convert.ToInt32(Console.ReadLine());
    int result = PageCount(n, p);
    Console.WriteLine(result);    
  }
}
