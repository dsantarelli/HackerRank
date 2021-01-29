using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
  static int jumpingOnClouds(int[] c)
  {
    int count = -1;
    for (int i = 0; i < c.Length; i++, count++)
    {
      if (i < c.Length - 2 && c[i + 2] == 0) i++;
    }
    return count;
  }

  static void Main(string[] args)
  {
    int n = Convert.ToInt32(Console.ReadLine());
    int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
    int result = jumpingOnClouds(c);
    Console.WriteLine(result);
  }
}
