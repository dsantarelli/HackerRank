using System;

class Solution
{
  static void CountSwaps(int[] a)
  {
    var swapsCount = 0;
    for (int i = 0; i < a.Length; i++)
    {
      for (int j = 0; j < a.Length - 1; j++)
      {        
        if (a[j] > a[j + 1])
        {
          var tmp = a[j];
          a[j] = a[j + 1];
          a[j + 1] = tmp;
          ++swapsCount;
        }
      }
    }

    Console.WriteLine($"Array is sorted in {swapsCount} swaps.");
    Console.WriteLine($"First Element: {a[0]}");
    Console.Write($"Last Element: {a[a.Length - 1]}");
  }

  static void Main(string[] args)
  {
    int n = Convert.ToInt32(Console.ReadLine());
    int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
    CountSwaps(a);
  }
}
