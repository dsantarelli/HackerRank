using System.Linq;
using System;

class Solution
{  
  static int FindDigits(int n)
  {
    return n
      .ToString()
      .Select(x => int.Parse(x.ToString()))
      .Where(x => x != 0)
      .GroupBy(x => x)      
      .Where(g => n % g.Key == 0)
      .Select(g => g.Count())
      .Sum();    
  }

  static void Main(string[] args)
  {    
    int t = Convert.ToInt32(Console.ReadLine());
    for (int tItr = 0; tItr < t; tItr++)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      int result = FindDigits(n);
      Console.WriteLine(result);
    }    
  }
}
