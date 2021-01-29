using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{
  private const int ELEMENTS_IN_MAGIC_SQUARE = 9;  
  private static int[] MAGIC_SQUARES_LINEAR = new int[]{
            8, 1, 6, 3, 5, 7, 4, 9, 2,
            6, 1, 8, 7, 5, 3, 2, 9, 4,
            4, 9, 2, 3, 5, 7, 8, 1, 6,
            2, 9, 4, 7, 5, 3, 6, 1, 8,
            8, 3, 4, 1, 5, 9, 6, 7, 2,
            4, 3, 8, 9, 5, 1, 2, 7, 6,
            6, 7, 2, 1, 5, 9, 8, 3, 4,
            2, 7, 6, 9, 5, 1, 4, 3, 8
    };
 
  private static List<int> GetMinCostLinear(int[] magicSquares, int[] flatMatrix)
  {
    var costs = new List<int>();
    int cost = 0;
    for (int i = 0; i < magicSquares.Length; i++)
    {
      int flatMatrixIndex = i % ELEMENTS_IN_MAGIC_SQUARE;
      if (i > 0 && flatMatrixIndex == 0)
      {
        costs.Add(cost);
        cost = 0;
      }
      int elementOne = magicSquares[i];
      int elementTwo = flatMatrix[flatMatrixIndex];
      cost += Math.Abs(elementOne - elementTwo);
    }
    costs.Add(cost);
    return costs;
  }

  private static int FormingMagicSquare(int[] flatMatrix)
    => GetMinCostLinear(MAGIC_SQUARES_LINEAR, flatMatrix).Min();

  static void Main(string[] args) 
    => Console.WriteLine(FormingMagicSquare(ReadNumbers(3)));

  private static int[] ReadNumbers(int lines)
  {
    string line = String.Empty;

    for (int i = 0; i < lines; i++)
      line += " " + Console.ReadLine();

    var stringNumbers = line.Trim().Split(' ');

    var numbers = new int[lines * lines];
    for (int i = 0; i < stringNumbers.Length; i++)
    {
      var stringNumber = stringNumbers[i];
      int number = int.Parse(stringNumber);
      numbers[i] = number;
    }
    return numbers;
  }
}
