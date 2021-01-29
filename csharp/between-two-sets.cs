using System.Collections.Generic;
using System.Linq;
using System;

class Result
{  
  public static int getTotalX(List<int> a, List<int> b)
  {
    var totalXs = 0;
    var maximumA = a.Max();
    var minimumB = b.Min();
    var counter = 1;
    var multipleOfMaxA = maximumA;

    while (multipleOfMaxA <= minimumB)
    {
      var factorOfAll = true;

      foreach (var item in a) 
      {
        if (multipleOfMaxA % item != 0)
        {
          factorOfAll = false;
          break;
        }
      }

      if (factorOfAll)
      {
        foreach (var item in b)
        {
          if (item % multipleOfMaxA != 0)
          {
            factorOfAll = false;
            break;
          }
        }
      }

      if (factorOfAll)
        totalXs++;

      counter++;
      multipleOfMaxA = maximumA * counter;
    }
    return totalXs;
  }
}

class Solution
{
  public static void Main(string[] args)
  {    
    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
    int n = Convert.ToInt32(firstMultipleInput[0]);
    int m = Convert.ToInt32(firstMultipleInput[1]);
    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
    List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();
    int total = Result.getTotalX(arr, brr);
    Console.WriteLine(total);    
  }
}
