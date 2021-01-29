using System;

class Solution
{
  static string CatAndMouse(int x, int y, int z)
  {
    int dis1 = Math.Abs(z - x);
    int dis2 = Math.Abs(z - y);
    if (dis1 > dis2) return "Cat B";
    if (dis1 < dis2) return "Cat A";
    return "Mouse C";
  }

  static void Main(string[] args)
  {   
    int q = Convert.ToInt32(Console.ReadLine());
    for (int qItr = 0; qItr < q; qItr++)
    {
      string[] xyz = Console.ReadLine().Split(' ');
      int x = Convert.ToInt32(xyz[0]);
      int y = Convert.ToInt32(xyz[1]);
      int z = Convert.ToInt32(xyz[2]);
      string result = CatAndMouse(x, y, z);
      Console.WriteLine(result);
    }
  }
}
