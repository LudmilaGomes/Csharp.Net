using System;

// um valor literal é um valor constante que nunca muda

namespace Values
{
  class MainClass
  {
    public static void Main()
    {
      // exibindo uma string
      Console.WriteLine("\"b\"");

      // exibindo um caractere!
      Console.WriteLine('b');
      // Console.WriteLine('\"b\"'); // não funciona
      
      // 'b' como parâmetro de WriteLine() funciona, pois estamos nos referindo
      // a um caractere único, e podemos, então, utilizar aspas simples
      // por isso '\"b\"' não funciona

      // exibindo um número inteiro
      Console.WriteLine(123);

      /*
      exibindo um número de ponto flutuante

      C# apresenta três tipos de variáveis para ponto flutuante, cujas diferenças entre eles
      reside na precisão que eles apresentam:
        float         ~6-9 dígitos
        double        ~15-17 dígitos
        decimal        28-29 dígitos

        0.25f ou 0.25F - indicamos que queremos criar um float
        2.625 - indicamos para o compilador que queremos criar um double
        12.39816m ou 12.39816M - indicamos que queremos criar um decimal
      */
      Console.WriteLine(0.25f);
      Console.WriteLine(2.625);
      Console.WriteLine(12.39816m);

      // exibe um valor booleano
      Console.WriteLine(true);
      Console.WriteLine(false);
    }
  }
}