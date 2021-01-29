using System.Linq;
using System;

class Solution
{
  static int MakeAnagram(string a, string b)
  {
    int result = 0;
    for (int i = 'a'; i <= 'z'; i++)
    {
      var c = (char)i;
      var aOccurrences = a.Count(x => x == c);
      var bOccurrences = b.Count(x => x == c);
      result += Math.Abs(aOccurrences - bOccurrences);
    }
    return result;
  }

  static void Main(string[] args)
  {    
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    int res = MakeAnagram(a, b);
    Console.WriteLine(res);
  }
}
