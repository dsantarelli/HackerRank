using System;

class Solution
{  
  static int SaveThePrisoner(int numberOfPrisoners, int numberOfSweets, int prisonerId)
  {
    var remainingPrisonersBeforeEnd = numberOfPrisoners - prisonerId + 1;

    if (numberOfSweets > remainingPrisonersBeforeEnd)
    {
      prisonerId = 1;
      numberOfSweets -= remainingPrisonersBeforeEnd;
      numberOfSweets %= numberOfPrisoners;
    }

    if (numberOfSweets == 0) prisonerId = numberOfPrisoners;
    else prisonerId += numberOfSweets - 1;

    return prisonerId;
  }

  static void Main(string[] args)
  {    
    int t = Convert.ToInt32(Console.ReadLine());
    for (int tItr = 0; tItr < t; tItr++)
    {
      string[] nms = Console.ReadLine().Split(' ');
      int n = Convert.ToInt32(nms[0]);
      int m = Convert.ToInt32(nms[1]);
      int s = Convert.ToInt32(nms[2]);
      int result = SaveThePrisoner(n, m, s);
      Console.WriteLine(result);
    }   
  }
}
