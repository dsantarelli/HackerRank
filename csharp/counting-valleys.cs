using System;

class Solution
{  
  static int countingValleys(int n, string s)
  {
    var steps = s.ToCharArray();    
    var lastSeaLevel = 0;    
    var output = 0;
    foreach (var step in steps)
    {
      var offset = step == 'U' ? 1 : -1;
      var currentSeaLevel = lastSeaLevel + offset;
      if (currentSeaLevel == 0 && lastSeaLevel < 0) ++output;
      lastSeaLevel = currentSeaLevel;
    }
    return output;
  }

  static void Main(string[] args)
  {    
    int n = Convert.ToInt32(Console.ReadLine());
    string s = Console.ReadLine();
    int result = countingValleys(n, s);
    Console.WriteLine(result);    
  }
}
