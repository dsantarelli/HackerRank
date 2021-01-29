using System.Collections.Generic;
using System.Linq;
using System;

class Result
{

  public static int PickingNumbers(List<int> a)
  {
    var maxCount = 0;
    var sortedList = a.OrderBy(x => x).ToList();

    for (int i = 0; i < sortedList.Count; i++)
    {
      var currentCount = 1;
      if (i > 0)
        if (sortedList[i] == sortedList[i - 1])
          continue;

      for (int j = i + 1; j < sortedList.Count; j++)
      {
        if (Math.Abs(sortedList[j] - sortedList[i]) <= 1)
          currentCount++;
        else
          break;
      }

      if (currentCount > maxCount)
        maxCount = currentCount;
    }
    return maxCount;
  }
}

class Solution
{
  public static void Main(string[] args)
  {    
    int n = Convert.ToInt32(Console.ReadLine().Trim());
    List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
    int result = Result.PickingNumbers(a);
    Console.WriteLine(result);
  }
}
