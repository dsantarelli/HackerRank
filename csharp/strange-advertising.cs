using System;

class Solution
{  
  static int ViralAdvertising(int n)
  {
    var totalLikes = 0D;
    var adShareCount = 5.0;
    for (int i = 0; i < n; i++)
    {
      totalLikes += Math.Floor(adShareCount / 2);
      adShareCount = Math.Floor(adShareCount / 2) * 3;
    }
    return (int)totalLikes;
  }

  static void Main(string[] args)
  {    
    int n = Convert.ToInt32(Console.ReadLine());
    int result = ViralAdvertising(n);
    Console.WriteLine(result);    
  }
}
