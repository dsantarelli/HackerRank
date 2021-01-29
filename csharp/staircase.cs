using System.Linq;
using System;

class Solution
{  
  static void staircase(int n)
  {
    for (int j = n - 1; j >= 0; j--)
    {
      var spaces = Enumerable.Range(0, j).Aggregate("", (a,b) => a + " ");
      var stairs = Enumerable.Range(0, n - j).Aggregate("", (a, b) => a + "#");
      var output = spaces + stairs;
      Console.WriteLine(output);
    }    
  }

  static void Main(string[] args)
  {
    int n = Convert.ToInt32(Console.ReadLine());
    staircase(n);
  }
}
