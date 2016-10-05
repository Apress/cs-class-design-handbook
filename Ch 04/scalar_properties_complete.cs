// created on 12/23/2002 at 6:53 PM
using System;
using System.Drawing;
using System.IO;

class FootballTeam
{
  private string name;
  private Color jerseyColor;
  private short wins, draws, defeats;
  private bool logging;

  public FootballTeam(string teamName, Color teamColor)
  {
    name = teamName;
    jerseyColor = teamColor;
  }

  public string Name { get { return name; } }

  public int Points
  {
    get { return ((wins * 3) + (draws * 1)); }
  }

  public Color JerseyColor
  {
    get
    {
      return jerseyColor;
    }
    set
    {
      if(value.Equals(Color.Black))
      {
        throw(new ArgumentException(
          "Teams cannot have Black jerseys"));
      }
      else
      {
        jerseyColor = value;
      }
    }
  }

  public bool Logging { set { logging = value; } }

  private FileStream LogStream
  {
    get
    {
      try
      {
        return (new FileStream(name + ".log", FileMode.Append, FileAccess.Write));
      }
      catch (System.IO.IOException)
      {
        return (new FileStream("Default.log", FileMode.Append, FileAccess.Write));
      }
    }
  }

  public void PlayGame(string opponent, short goalsFor, 
             short goalsAgainst)
  {
    if (goalsFor > goalsAgainst)
      wins++;
    else if (goalsFor == goalsAgainst)
      draws++;
    else
      defeats++;

    if (logging)
    {
      StreamWriter sw = new StreamWriter(LogStream);
      sw.WriteLine("{0} {1}-{2} {3}", name, goalsFor, 
           goalsAgainst, opponent);
      sw.Flush();
      sw.Close();
    }
  }
}
class Season
{
  static void Main()
  {
    FootballTeam myTeam = new FootballTeam("Wolves", Color.Gold);

    myTeam.Logging = true;

    myTeam.PlayGame("Portsmouth", 2, 1);
    myTeam.PlayGame("Manchester United", 2, 3);
    myTeam.PlayGame("West Bromwich Albion", 4, 0);
    myTeam.PlayGame("Stoke City", 3, 2);
    myTeam.PlayGame("West Ham", 1, 1);

    Console.WriteLine(myTeam.Name + " (" + myTeam.JerseyColor.Name + ") - " + myTeam.Points.ToString());

  }
}
