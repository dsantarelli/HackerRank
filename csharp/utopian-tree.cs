using System;

class Solution
{  
  static int UtopianTree(int numberOfCycles)
  {    
    var finalHeightOfSapling = 1;
    bool isSpring = true;
    while (numberOfCycles > 0)
    {
      if (isSpring)
      {
        finalHeightOfSapling *= 2;
        isSpring = false;
      }
      else
      {
        finalHeightOfSapling++;
        isSpring = true;
      }
      numberOfCycles--;
    }
    return finalHeightOfSapling;
  }

  static void Main(string[] args)
  {    
    int t = Convert.ToInt32(Console.ReadLine());
    for (int tItr = 0; tItr < t; tItr++)
    {
      int n = Convert.ToInt32(Console.ReadLine());
      int result = UtopianTree(n);
      Console.WriteLine(result);
    }
  }
}
