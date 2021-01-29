using System.Collections.Generic;
using System;

class Result
{
  public static List<int> gradingStudents(List<int> grades)
  {
    var output = new List<int>();
    foreach (var grade in grades)
    {
      var mod = grade % 5;
      if (mod >= 3 && grade >= 38) output.Add(grade + 5 - mod);      
      else output.Add(grade);
    }
    return output;
  }
}

class Solution
{
  public static void Main(string[] args)
  {
    int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
    List<int> grades = new List<int>();
    for (int i = 0; i < gradesCount; i++)
    {
      int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
      grades.Add(gradesItem);
    }

    List<int> result = Result.gradingStudents(grades);
    Console.WriteLine(String.Join("\n", result));
  }
}
