using System;

class Solution
{  
  static long SubstrCount(int n, string s)
  {
    int c, i = 0, j, ans = 0;
    var sameCharCount = new int[n];

    while (i < n)
    {
      j = i + 1;
      c = 1;

      while (j < n && s[i] == s[j])
      {
        ++j;
        ++c;
      }
      
      ans += (c * (c + 1)) >> 1;
      sameCharCount[i] = c;
      i = j;
    }

    for (j = 1; j < n - 1; ++j)
    {
      if (s[j] == s[j - 1])      
        sameCharCount[j] = sameCharCount[j - 1];      
      
      if (s[j - 1] == s[j + 1] && s[j] != s[j - 1])      
        ans += Math.Min(sameCharCount[j - 1], sameCharCount[j + 1]);      
    }

    return ans;
  }

  static void Main(string[] args)
  {
    int n = Convert.ToInt32(Console.ReadLine());
    string s = Console.ReadLine();
    long result = SubstrCount(n, s);
    Console.WriteLine(result);
  }
}
