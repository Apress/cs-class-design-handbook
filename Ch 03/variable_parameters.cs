// created on 12/2/2002 at 4:13 PM
using System;
class Statistics
{
  public static double AverageScores(params int[] scores)
  {
    int total = 0;
    double average = 0;

    foreach(int score in scores)
    {
      total = total + score;
    }

    average = (total / scores.GetLength(0));

    return average;
  }
}
public class params_example
{
  public static void Main()
  {
    Console.WriteLine("Average - " + Statistics.AverageScores(7, 2, 5, 8, 9, 6, 8, 1));
    Console.WriteLine("Average - " + Statistics.AverageScores(3, 4, 2, 5));
    Console.ReadLine();
  }
}
