using System;
using System.IO;

class Solution
{  
  static string timeConversion(string s)
  {    
    return Convert.ToDateTime(s).ToString("HH:mm:ss");
  }

  static void Main(string[] args)
  {
    TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    string s = Console.ReadLine();
    string result = timeConversion(s);
    tw.WriteLine(result);
    tw.Flush();
    tw.Close();
  }
}
