using System.Linq;
using System;

class Solution
{
  static bool TwoStrings(string s1, string s2)
  {
    var chars1 = s1.Distinct();
    var chars2 = s2.Distinct();
    return chars1.Any(c => chars2.Contains(c));
  }

  static void Main(string[] args)
  {    
    int q = Convert.ToInt32(Console.ReadLine());
    for (int qItr = 0; qItr < q; qItr++)
    {
      string s1 = Console.ReadLine();
      string s2 = Console.ReadLine();      
      Console.WriteLine(TwoStrings(s1, s2) ? "YES" : "NO");
    }    
  }
}
