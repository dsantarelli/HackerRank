using System.Linq;
using System;
using System.Collections.Generic;

class Solution
{  
  static bool CheckMagazine(string[] magazine, string[] note)
  {
    var magazineDictionary = getWordDictionary(magazine);
    var noteDictionary = getWordDictionary(note);
    return noteDictionary.All(keyValue => 
      magazineDictionary.ContainsKey(keyValue.Key) && 
      magazineDictionary[keyValue.Key] >= keyValue.Value);
  }

  private static Dictionary<string, int> getWordDictionary(string[] words)
  {
    var dictionary = new Dictionary<string, int>();
    foreach (var word in words)
    {
      if (dictionary.ContainsKey(word)) dictionary[word] = ++dictionary[word];
      else dictionary.Add(word, 1);
    }
    return dictionary;
  }

  static void Main(string[] args)
  {
    string[] mn = Console.ReadLine().Split(' ');
    int m = Convert.ToInt32(mn[0]);
    int n = Convert.ToInt32(mn[1]);
    string[] magazine = Console.ReadLine().Split(' ');
    string[] note = Console.ReadLine().Split(' ');
    Console.Write(CheckMagazine(magazine, note) ? "Yes" : "No");
  }
}
