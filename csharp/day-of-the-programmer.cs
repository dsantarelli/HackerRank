using System;

class Solution
{  
  static string DayOfProgrammer(int year)
  {        
    if (year < 1918 && year % 100 == 0)
      return GetAnswerDate(year, 255);
    
    else if (year == 1918)    
      return GetAnswerDate(year, 269);
    
    else
      return GetAnswerDate(year, 256); 
  }

  static string GetAnswerDate(int year, int day) 
    => new DateTime(year, 1, 1).AddDays(day - 1).ToString("dd.MM.yyyy");

  static void Main(string[] args)
  {    
    int year = Convert.ToInt32(Console.ReadLine().Trim());
    string result = DayOfProgrammer(year);
    Console.WriteLine(result);
  }
}
