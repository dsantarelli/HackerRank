using System;

class Solution
{  
  static int AlternatingCharacters(string s)
  {
    char? currenItem = null;
    int result = 0;
    foreach (var item in s)
    {
      if (item == currenItem) ++result;
      currenItem = item;
    }
    return result;
  }

  static void Main(string[] args)
  {    
    int q = Convert.ToInt32(Console.ReadLine());
    for (int qItr = 0; qItr < q; qItr++)
    {
      string s = Console.ReadLine();
      int result = AlternatingCharacters(s);
      Console.WriteLine(result);
    }
  }
}
