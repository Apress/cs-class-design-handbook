// created on 12/21/2002 at 1:12 PM
using System;

public class GuessTheNumber
{
  public const int LOW=1;
  public const int HIGH=10;
  
  public string tryGuess(int guess)
  {
    Random generator = new Random();
    int randomNumber=generator.Next(LOW,HIGH);
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
    GuessTheNumber numberGame=new GuessTheNumber();

    Console.WriteLine("We're going to play a guessing game!");
    Console.WriteLine("Please enter a number between " 
                       + GuessTheNumber.LOW + " and " 
                       + GuessTheNumber.HIGH + ":");

    try
    {
      int myGuess=int.Parse(Console.ReadLine());
      if ((myGuess > GuessTheNumber.HIGH) || 
          (myGuess < GuessTheNumber.LOW))
           Console.WriteLine("Value must be between " 
                             + GuessTheNumber.LOW + " and " 
                             + GuessTheNumber.HIGH);
      else
      {
        Console.WriteLine(numberGame.tryGuess(myGuess));
      }
    }
    catch
    {
      Console.WriteLine("You need to enter a number!");
    }
  }
}
