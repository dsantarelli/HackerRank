using System.Collections.Generic;
using System;

class Solution
{  
  static int sockMerchant(int n, int[] ar)
  {
    var result = 0;
    var buffer = new List<int>();
    foreach (var value in ar)
    {
      if (buffer.Count > 0 && buffer.Contains(value))
      {
        buffer.Remove(value);
        ++result;
      }
      else buffer.Add(value);
    }   
    return result;
  }

  static void Main(string[] args)
  {    
    int n = Convert.ToInt32(Console.ReadLine());
    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
    int result = sockMerchant(n, ar);
    Console.WriteLine(result);    
  }
}
