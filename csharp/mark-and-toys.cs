using System.Linq;
using System;

class Solution
{
  static int MaximumToys(int[] prices, int budget)
  {
    var remainingBudget = budget;
    var toys = 0;
    foreach (var price in prices.OrderBy(x => x))
    {
      if (remainingBudget > price)
      {
        ++toys;
        remainingBudget -= price;
      }
    }
    return toys;
  }

  static void Main(string[] args)
  {    
    string[] nk = Console.ReadLine().Split(' ');
    int n = Convert.ToInt32(nk[0]);
    int k = Convert.ToInt32(nk[1]);
    int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));
    int result = MaximumToys(prices, k);
    Console.WriteLine(result);
  }
}
