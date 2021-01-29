using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
  private static int MinimumSwaps(int[] arr)
  {
    int swaps = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
      if (arr[i] != (i + 1))
      {
        for (int j = i + 1; j < arr.Length; j++)
        {
          if (arr[j] == (i + 1))
          {
            int tmp = arr[j];
            arr[j] = arr[i];
            arr[i] = tmp;
            swaps++;
            break;
          }
        }
      }
    }
    return swaps;
  }

  static void Main(string[] args)
  {    
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
    int res = MinimumSwaps(arr);
    Console.WriteLine(res);
  }
}
