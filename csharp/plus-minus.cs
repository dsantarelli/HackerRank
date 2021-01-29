using System;
using System.Linq;

class Solution
{  
  static void plusMinus(int[] arr)
  {        
    Console.WriteLine((decimal)arr.Where(x => x > 0).Count() / arr.Length);
    Console.WriteLine((decimal)arr.Where(x => x < 0).Count() / arr.Length);
    Console.WriteLine((decimal)arr.Where(x => x == 0).Count() / arr.Length);
  }

  static void Main(string[] args)
  {
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
    plusMinus(arr);
  }
}
