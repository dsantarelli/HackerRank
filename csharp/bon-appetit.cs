using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{
  static void BonAppetit(List<int> bill, int k, int bCharged)
  {    
    int total = bill.Sum();    
    int bActual = total - bill[k];
    int bDifference = Math.Abs(bCharged - (bActual / 2));
    if (bDifference == 0) Console.Write("Bon Appetit");    
    else Console.Write(bDifference);    
  }

  static void Main(string[] args)
  {
    string[] nk = Console.ReadLine().TrimEnd().Split(' ');
    int n = Convert.ToInt32(nk[0]);
    int k = Convert.ToInt32(nk[1]);
    List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();
    int b = Convert.ToInt32(Console.ReadLine().Trim());
    BonAppetit(bill, k, b);
  }
}
