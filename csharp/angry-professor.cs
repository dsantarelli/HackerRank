using System.Linq;
using System;

class Solution
{
  static string AngryProfessor(int k, int[] a) 
    => (a.Where(x => x <= 0).Count() >= k) ? "NO" : "YES";

  static void Main(string[] args)
  {    
    int t = Convert.ToInt32(Console.ReadLine());
    for (int tItr = 0; tItr < t; tItr++)
    {
      string[] nk = Console.ReadLine().Split(' ');
      int n = Convert.ToInt32(nk[0]);
      int k = Convert.ToInt32(nk[1]);
      int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
      string result = AngryProfessor(k, a);
      Console.WriteLine(result);
    }    
  }
}
