using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{  
  static int[] PermutationEquation(int[] p)
  {
    var dictionary = new Dictionary<int, int>();

    for (int i = 0; i < p.Length; i++)    
      dictionary.Add(p[i], i + 1);    

    return Enumerable.Range(1, p.Length)
            .Select(x => dictionary[dictionary[x]])
            .ToArray();            
  }

  static void Main(string[] args)
  {    
    int n = Convert.ToInt32(Console.ReadLine());
    int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp));
    int[] result = PermutationEquation(p);
    Console.WriteLine(string.Join("\n", result));
  }
}
