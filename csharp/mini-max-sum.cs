using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{  
  static void miniMaxSum(int[] arr)
  {
    var permutations = new List<List<long>>();
    
    for (int i = 0; i < arr.Length; i++)
    {
      var list = arr.Select(x => (long)x).ToList();
      list[i] = 0;
      permutations.Add(list);
    } 
      
    var sums = permutations.Select(x => x.Sum());    
    Console.WriteLine(sums.Min() + " " + sums.Max());
  }

  static void Main(string[] args)
  {
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
    miniMaxSum(arr);
  }
}
