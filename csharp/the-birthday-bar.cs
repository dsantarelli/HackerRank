using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{
  static int birthday(List<int> s, int d, int m)
  {
    int start = 0;    
    int result = 0;

    while (true)
    {
      if (s.Skip(start).Take(m).Sum() == d) ++result;
      ++start;      
      if (start + m > s.Count) break;
    }

    return result;
  }

  static void Main(string[] args)
  {
    int n = Convert.ToInt32(Console.ReadLine().Trim());
    List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
    string[] dm = Console.ReadLine().TrimEnd().Split(' ');
    int d = Convert.ToInt32(dm[0]);
    int m = Convert.ToInt32(dm[1]);
    int result = birthday(s, d, m);
    Console.WriteLine(result);
  }
}
