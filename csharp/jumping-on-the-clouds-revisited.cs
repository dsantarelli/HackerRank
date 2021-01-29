using System;

class Solution
{  
  static int JumpingOnClouds(int[] clouds, int jumpSize)
  {
    var totalEnergyRemaining = 100;
    var currentCloud = 0;
    while (true)
    {      
      currentCloud = (currentCloud + jumpSize) % clouds.Length;

      if (clouds[currentCloud] == 1)
        totalEnergyRemaining -= 3;
      else
        totalEnergyRemaining--;

      if (currentCloud == 0)
        break;
    }

    return totalEnergyRemaining;
  }

  static void Main(string[] args)
  {    
    string[] nk = Console.ReadLine().Split(' ');
    int n = Convert.ToInt32(nk[0]);
    int k = Convert.ToInt32(nk[1]);
    int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
    int result = JumpingOnClouds(c, k);
    Console.WriteLine(result);    
  }
}
