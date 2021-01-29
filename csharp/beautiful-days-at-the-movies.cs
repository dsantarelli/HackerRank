using System.Linq;
using System;

class Solution
{  
  static int BeautifulDays(int i, int j, int k)
  {
    return Enumerable.Range(i, j - i + 1)
        .Select(x =>
        {
          var y = int.Parse(new string(x.ToString().Reverse().ToArray()).TrimStart('0'));
          return ((x - y) % k) == 0 ? 1 : 0;
        })
        .Sum();
  }

  static void Main(string[] args)
  {    
    string[] ijk = Console.ReadLine().Split(' ');
    int i = Convert.ToInt32(ijk[0]);
    int j = Convert.ToInt32(ijk[1]);
    int k = Convert.ToInt32(ijk[2]);
    int result = BeautifulDays(i, j, k);
    Console.WriteLine(result);
  }
}
