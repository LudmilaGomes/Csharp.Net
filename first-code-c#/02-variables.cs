using System;

namespace Variables
{
  class MainClass
  {
    public static void Main()
    {
      // esse padrão de escrita de nome de variável é a convenção usada
      string firstName;
      // Console.WriteLine(firstName); // ocorre erro, pois variável não foi inicializada
      firstName = "Ludmila";
      Console.WriteLine(firstName);
      firstName = "Gomes";
      Console.WriteLine(firstName);

      int numero = 12;
      Console.WriteLine(numero);
      // Console.WriteLine(numero); // o mesmo ocorre aqui, variável não foi inicializada

      // também podemos declarar uma variável de forma implícita

      var message = "Hello, World!";
      // message = 12.39816m; // erro! Cannot implicitly convert type 'decimal' to 'string'
      Console.WriteLine(message);

      // variáveis declaradas usando 'var' precisam obrigatoriamente ser inicializadas
      // var messg; // An implicitly typed local variable declarator must include an initialize
      // 'var' é muito útil quando ainda não sabemos qual será o valor armazenado pela variável

      // ========

      string name = "Bob";
      int numberMessages = 3;
      // float temperat = 34.4; // é necessário usar o sufixo 'f' após o número para que ele seja float!
      float temperat = 34.4f;

      Console.Write("Hello, ");
      Console.Write(name);
      Console.Write("! You have ");
      Console.Write(numberMessages);
      Console.Write(" messages in your inbox. The temperature is ");
      Console.Write(temperat);
      Console.Write(" celsius.");
    }
  }
}