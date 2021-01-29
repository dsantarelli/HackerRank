using System;

class Solution
{  
  static int MinimumAbsoluteDifference(int[] arr)
  {
    Array.Sort(arr);
    int differece = int.MaxValue;

    for (int i = 0; i < arr.Length - 1; i++)
      if (arr[i + 1] - arr[i] < differece) differece = arr[i + 1] - arr[i];

    return differece;
  }
 
  static void Main(string[] args)
  {    
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
    int result = MinimumAbsoluteDifference(arr);
    Console.WriteLine(result);
  }
}
