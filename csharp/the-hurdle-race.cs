using System.Linq;
using System;

class Solution
{  
  static int HurdleRace(int k, int[] height)
  {
    var max = height.Max();
    return max > k ? max - k : 0;
  }

  static void Main(string[] args)
  {    
    string[] nk = Console.ReadLine().Split(' ');
    int n = Convert.ToInt32(nk[0]);
    int k = Convert.ToInt32(nk[1]);
    int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp));
    int result = HurdleRace(k, height);
    Console.WriteLine(result);
  }
}
