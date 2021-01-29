using System.IO;
using System;
using System.Linq;

class Solution
{  
  static long aVeryBigSum(long[] ar)
  {
    return ar.Sum();
  }

  static void Main(string[] args)
  {
    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    int arCount = Convert.ToInt32(Console.ReadLine());
    long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
    long result = aVeryBigSum(ar);
    textWriter.WriteLine(result);
    textWriter.Flush();
    textWriter.Close();
  }
}
