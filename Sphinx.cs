using System;
using System.Collections.Generic;

class Sphinx
{
  static void Main()
  {

    Dictionary<string, string>[] riddles = new Dictionary<string, string>[]
    {
      new Dictionary<string, string>()
      {
        {"Question", "Test riddle, please answer yes."},
        {"Answer", "yes"}
      }
    };
    Dictionary<string, string> currentRiddle = riddles[0];
    AskRiddle(currentRiddle);

  }

  static bool AskRiddle(Dictionary<string, string> riddle)
  {
    Console.WriteLine(riddle["Question"]);
    Console.WriteLine("Enter Answer Here");
    string answer = Console.ReadLine();

    if (answer == riddle["Answer"])
    {
      Console.WriteLine("Correct, YOURE ALIVE");
      return true;
    }
    else
    {
      Console.WriteLine("The Sphinx ate you, good night");
      return false;
    }
  }
}





// var dict = new Dictionary<int, string>()
// { 
//    {0, "string"}, 
//    {1, "string2"},
//    {2, "string3"}
// };