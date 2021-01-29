using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
  public class Range
  {
    public long Min { get; set; }
    public long Max { get; set; }

    public bool Intersect(Range range)
    {     
      return range.Min <= Max && range.Max >= Min;
    }

    public override string ToString()
    {
      return "[" + Min + "," + Max + "]";
    }
  }

  static long gridlandMetro(long n, long m, int k, int[][] track)
  {
    long lampposts = 0;
    var tracks = new Dictionary<long, List<Range>>();
    
    for (int i = 0; i < track.Length; i++)
    {
      var row = track[i][0];      
      var range = new Range { Min = track[i][1], Max = track[i][2] };

      if (!tracks.ContainsKey(row))
        tracks.Add(row, new List<Range>(new[] { range }));              
      else
      {
        var ranges = tracks[row];
        var found = ranges.FirstOrDefault(x => x.Intersect(range));
        if (found != null)
        {
          if (found.Min > range.Min) found.Min = range.Min;
          if (found.Max < range.Max) found.Max = range.Max;           
        }
        else ranges.Add(range);            
      }
    }

    lampposts += tracks
      .AsEnumerable()
      .Select(x => m - x.Value.Select(r => Math.Abs(r.Max - r.Min + 1)).Sum())
      .Sum();
    
    lampposts += m * (n - tracks.Keys.Count);
   
    return lampposts;
  }

  static void Main(string[] args)
  {  
    string[] nmk = Console.ReadLine().Split(' ');
    int n = Convert.ToInt32(nmk[0]);
    int m = Convert.ToInt32(nmk[1]);
    int k = Convert.ToInt32(nmk[2]);

    int[][] track = new int[k][];

    for (int i = 0; i < k; i++)
    {
      track[i] = Array.ConvertAll(Console.ReadLine().Split(' '), trackTemp => Convert.ToInt32(trackTemp));
    }

    long result = gridlandMetro(n, m, k, track);
    Console.WriteLine(result);    
  }
}
