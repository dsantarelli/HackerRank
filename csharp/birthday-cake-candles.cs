using System.IO;
using System.Linq;
using System;

class Solution
{  
  static int birthdayCakeCandles(int[] ar)
  {
    var max = ar.Max();
    return ar.Count(x => x == max);
  }

  static void Main(string[] args)
  {
    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    int arCount = Convert.ToInt32(Console.ReadLine());
    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
    int result = birthdayCakeCandles(ar);
    textWriter.WriteLine(result);
    textWriter.Flush();
    textWriter.Close();
  }
}
