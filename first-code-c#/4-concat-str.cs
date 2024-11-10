using System;

namespace ConcatenateStr
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      string name = "Ludmila! ";
      string hello = "Hello, ";
      Console.WriteLine(name + hello);

      string message = hello + name;
      Console.WriteLine(message);

      string firstName = "Bob";
      string greeting = "Hello";
      message = greeting + "," + " " + firstName + "!";
      Console.WriteLine(message);
    }
  }
}