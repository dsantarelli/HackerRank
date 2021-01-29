using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{  
  static int SherlockAndAnagrams(string s)
  {    
    var total = 0;    
    for (int k = 1; k < s.Length; k++)
    {      
      var i = 0;
      var dictionary = new Dictionary<string, int>();

      while (i + k <= s.Length)
      {
        var value = new string(s.Skip(i).Take(k).OrderBy(x => x).ToArray());
        if (dictionary.ContainsKey(value))
        {
          var occurencies = dictionary[value];
          total += occurencies;
          dictionary[value] = occurencies + 1;
        }
        else dictionary.Add(value, 1);

        ++i;
      }      
    }
    return total;
  } 

  static void Main(string[] args)
  {    
    int q = Convert.ToInt32(Console.ReadLine());
    for (int qItr = 0; qItr < q; qItr++)
    {
      string s = Console.ReadLine();
      int result = SherlockAndAnagrams(s);
      Console.WriteLine(result);
    }
  }
}
