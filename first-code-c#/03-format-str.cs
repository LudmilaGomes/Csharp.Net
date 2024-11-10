using System;

namespace FormatStr
{
  class MainClass
  {
    public static void Main()
    {
      Console.WriteLine("Hello\nWorld!\n");
      Console.WriteLine("Hello\tWorld!");

      // Console.WriteLine("Hello "World"!"); // Unexpected symbol `World'
      Console.WriteLine("Hello \"World\"!");

      // Console.WriteLine("c:\source\repos"); // Unrecognized escape sequence `\s'
      Console.WriteLine("c:\\source\\repos");

      Console.WriteLine("Generating invoices for customer \"Gomes Corp\" ... \n");
      Console.WriteLine("Invoice: 1021\t\tComplete!");
      Console.WriteLine("Invoice: 1022\t\tComplete!");
      Console.WriteLine("\nOutput Directory:\t");

      // verbatim
      Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
      // usando verbatim, caracteres de escape não funcionam e são exibidos da forma como são escritos!
      Console.Write(@"c:\invoices\n"); 

      // caracteres Unicode
      // konnichiwa world
      Console.WriteLine("\n\u3053\u3093\u306B\u3061\u306F World!");
    }
  }
}