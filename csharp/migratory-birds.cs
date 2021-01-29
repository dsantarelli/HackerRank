using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{    
    static int migratoryBirds(List<int> arr)
    {
        int[] counter = new int[6];
        int result = 1; int max = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            counter[arr[i]]++;
        }

        for (int i = 1; i <= 5; i++)
        {
            if (counter[i] > max)
            {
                result = i;
                max = counter[i];
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        int result = migratoryBirds(arr);
        Console.WriteLine(result);
    }
}
