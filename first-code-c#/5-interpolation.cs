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

      // ========

      string projectName = "ACME";
      string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

      Console.WriteLine("View English output:\n\tc:\\Exercise\\" + projectName + "\\data.txt");
      Console.WriteLine(russianMessage + "\n\tc:\\Exercise\\" + projectName + "\\ru-RU\\data.txt");
    }
  }
}