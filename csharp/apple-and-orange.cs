using System;

class Solution
{
  static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
  {
    int applesCount = 0;
    int orangesCount = 0;

    foreach (var apple in apples)
      if (FallOnSamHouse(s, t, a, apple)) ++applesCount;

    foreach (var orange in oranges)
      if (FallOnSamHouse(s, t, b, orange)) ++orangesCount;

    Console.WriteLine(applesCount);
    Console.WriteLine(orangesCount);
  }

  private static bool FallOnSamHouse(int s, int t, int treeLocation, int treeOffset)
  {
    var x = treeLocation + treeOffset;
    return (x >= s && x <= t);
  }

  static void Main(string[] args)
  {
    string[] st = Console.ReadLine().Split(' ');
    int s = Convert.ToInt32(st[0]);
    int t = Convert.ToInt32(st[1]);
    string[] ab = Console.ReadLine().Split(' ');
    int a = Convert.ToInt32(ab[0]);
    int b = Convert.ToInt32(ab[1]);
    string[] mn = Console.ReadLine().Split(' ');
    int m = Convert.ToInt32(mn[0]);
    int n = Convert.ToInt32(mn[1]);
    int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));
    int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));
    countApplesAndOranges(s, t, a, b, apples, oranges);
  }
}
