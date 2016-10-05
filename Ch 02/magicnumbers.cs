// created on 12/21/2002 at 1:08 PM
using System;

public class GuessTheNumber
{
  public string tryGuess(int guess)
  {
    Random generator = new Random();
    int randomNumber=generator.Next(1,10);
    if (guess == randomNumber)
      return "You guessed it!";
    else
      return "Sorry, the number was " + randomNumber.ToString();
  }
}

class MagicNumbers
{
  [STAThread]
  static void Main(string[] args)
  {
    Console.WriteLine("We're going to play a guessing game!");
    Console.WriteLine("Please enter a number between 1 and 10:");

    try
    {
      int myGuess=int.Parse(Console.ReadLine());
      if ((myGuess > 10) || (myGuess <1))
        Console.WriteLine("Value must be between 1 and 10");
      else
      {
        GuessTheNumber gtn=new GuessTheNumber();
        Console.WriteLine(gtn.tryGuess(myGuess));
      }
    }
    catch
    {
      Console.WriteLine("You need to enter a number!");
    }
  }
}
