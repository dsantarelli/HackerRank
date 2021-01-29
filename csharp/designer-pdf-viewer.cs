using System.Linq;
using System;

class Solution
{
  static int DesignerPdfViewer(int[] h, string word) {

    var maxHeight = word.Select(c => h[(int)c - 97]).Max();
    return word.Length * maxHeight;
  }

  static void Main(string[] args)
  {    
    int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
    string word = Console.ReadLine();
    int result = DesignerPdfViewer(h, word);
    Console.WriteLine(result);
  }
}
