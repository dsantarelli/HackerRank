using System;

class Solution
{
  static int HourglassSum(int[][] arr)
  {

    int rowCount = arr.Length - 2;
    int maxSum = int.MinValue;
    for (int i = 0; i < rowCount; i++)
    {      
      int columnCount = arr[i].Length - 2;
      for (int j = 0; j < columnCount; j++)
      {        
        int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                + arr[i + 1][j + 1]
                + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
        if (maxSum < sum)
        {
          maxSum = sum;
        }
      }
    }
    return maxSum;
  }


  static void Main(string[] args)
  {   
    int[][] arr = new int[6][];
    for (int i = 0; i < 6; i++)
    {
      arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
    }
    int result = HourglassSum(arr);
    Console.WriteLine(result);
  }
}
