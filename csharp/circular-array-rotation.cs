using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{  
  static int[] CircularArrayRotation(int[] a, int k, int[] queries)
  {
    var linkedList = new LinkedList<int>(a);
    for (int i = 0; i < k; i++)
    {
      var last = linkedList.Last;
      linkedList.RemoveLast();
      linkedList.AddFirst(last);
    }
    return queries.Select(x => linkedList.ElementAt(x)).ToArray();    
  }

  static void Main(string[] args)
  {    
    string[] nkq = Console.ReadLine().Split(' ');
    int n = Convert.ToInt32(nkq[0]);
    int k = Convert.ToInt32(nkq[1]);
    int q = Convert.ToInt32(nkq[2]);
    int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
    int[] queries = new int[q];
    for (int i = 0; i < q; i++)
    {
      int queriesItem = Convert.ToInt32(Console.ReadLine());
      queries[i] = queriesItem;
    }
    int[] result = CircularArrayRotation(a, k, queries);
    Console.WriteLine(string.Join("\n", result));
  }
}
