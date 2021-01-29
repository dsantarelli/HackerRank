using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Solution
{
  static List<int> compareTriplets(List<int> a, List<int> b)
  {
    var output = new int[2];
    for (int i = 0; i < a.Count; i++)
    {
      if (a[i] > b[i]) output[0] += 1;
      else if (a[i] < b[i]) output[1] += 1;      
    }
    return output.ToList();
  }

  static void Main(string[] args)
  {
    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
    List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
    List<int> result = compareTriplets(a, b);
    textWriter.WriteLine(String.Join(" ", result));
    textWriter.Flush();
    textWriter.Close();
  }
}
