using System.Linq;
using System;

class Solution
{  
  static int[] ReverseArray(int[] array)
  {
    return array.Reverse().ToArray();
  }

  static void Main(string[] args)
  {    
    int arrCount = Convert.ToInt32(Console.ReadLine());
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
    int[] res = ReverseArray(arr);
    Console.WriteLine(string.Join(" ", res));
  }
}
