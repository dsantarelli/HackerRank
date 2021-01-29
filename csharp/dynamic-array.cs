using System.Collections.Generic;
using System.Linq;
using System;

class Result
{  
  public static List<int> DynamicArray(int n, List<List<int>> queries)
  {
    List<int> seq;
    var seqList = new List<List<int>>(new List<int>[n]);
    var lastAns = new List<int>();
    foreach (var query in queries)
    {      
      var queryType = query[0];
      var x = query[1];
      var y = query[2];
      var seqIndex = (x ^ (lastAns.Count == 0 ? 0 : lastAns.Last())) % n;
      switch (queryType)
      {
        case 1:
          if (seqList[seqIndex] != null)
            seqList[seqIndex].Add(y);
          else
          {
            seq = new List<int>();
            seq.Add(y);
            seqList[seqIndex] = seq;
          }
          break;
        case 2:
          seq = seqList[seqIndex];
          lastAns.Add(seq[y % seq.Count]);
          break;
      }
    }
    return lastAns;
  }
}

class Solution
{
  public static void Main(string[] args)
  {   
    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
    int n = Convert.ToInt32(firstMultipleInput[0]);
    int q = Convert.ToInt32(firstMultipleInput[1]);
    List<List<int>> queries = new List<List<int>>();
    for (int i = 0; i < q; i++)
    {
      queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
    }
    List<int> result = Result.DynamicArray(n, queries);
    Console.WriteLine(String.Join("\n", result));    
  }
}
