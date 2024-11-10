using System;

namespace InterpStr
{
  class MainClass
  {
    public static void Main()
    {
      string name = "Bob";
      int numberMessages = 3;
      float temperat = 34.4f;
      string message = $"Hello, {name}! You have {numberMessages} new messages and the temperature is {temperat}.";
      Console.WriteLine(message);

      int version = 11;
      string updateText = "Update to Windows";
      message = $"{updateText} {version} now!!!";
      Console.WriteLine(message);
    }
  }
}