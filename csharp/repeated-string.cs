using System;

class Solution
{

  // Complete the repeatedString function below.
  static long repeatedString(string s, long n)
  {
    var count = 0L;
    foreach (var letter in s)
    {
      if (letter == 'a')
        count++;
    }

    var possibleStringRepeatitions = n / s.Length;
    count *= possibleStringRepeatitions;
    var offsetStringLength = n % s.Length;

    for (int i = 0; i < offsetStringLength; i++)
    {
      if (s[i] == 'a')
        count++;
    }
    return count;
  }

  static void Main(string[] args)
  {   
    string s = Console.ReadLine();
    long n = Convert.ToInt64(Console.ReadLine());
    long result = repeatedString(s, n);
    Console.WriteLine(result);
  }
}
