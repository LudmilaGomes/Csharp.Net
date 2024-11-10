using System;

namespace Operations
{
  class MainClass
  {
    public static void Main()
    {
      // aqui, temos a operação de SOMA
      int firstNumber = 12;
      int secondNumber = 7;
      Console.WriteLine(firstNumber + secondNumber); // saída 19
      // o compilador de C# entende a intenção do programador. Assim, o operador '+' tem ao seu redor
      // dois valores numéricos, assim sendo, realiza uma soma. Se fossem strings, seria realizada uma
      // concatenação dessas strings
      
      // quando misturamos tipos de dados diferentes, forçamos uma conversão implícita!
      string firstName = "Bob";
      int widgetsSold = 7;
      // reconhecendo string e int, o compilador converte o número inteiro em string para que possa
      // exibir o resultado com WriteLine()
      Console.WriteLine(firstName + " sold " + widgetsSold + " widgets."); // Bob sold 7 widgets.
      
      // a conversão implícita novamente transforma o inteiro em string para exibir toda a string concatenada na tela
      Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); // Bob sold 77 widgets.

      // a depender da necessidade, podemos usar parênteses para deixar clara a intenção e o que deve ser convertido
      // em string e em int
      Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); // Bob sold 14 widgets.

      int sum = 7 + 5;
      int difference = 7 - 5;
      int product = 7 * 5;
      int quotientI = 7 / 5;
      double quotientD = (7 / 5);

      Console.WriteLine("Sum: " + sum);               // 12
      Console.WriteLine("Difference: " + difference); // 2
      Console.WriteLine("Product: " + product);       // 35
      // como a variável quotient é do tipo int, o resultado (que seria um float) é truncado e apenas a parte inteira aparece
      Console.WriteLine("Quotient: " + quotientI);     // 1
      // aqui, ainda temos um resultado inteiro; isso acontece porque a expressão (7 / 5) é composta por inteiros!
      quotientD = (7.0 / 5.0);
      Console.WriteLine("Quotient: " + quotientD);     // 1.4 agora sim!

      int first = 7;
      int second = 5;
      decimal quotient = (decimal)first / (decimal)second;
      Console.WriteLine(quotient);

      // como encontrar o resto de uma divisão: operador %
      Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
      Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

      /*
      ordem de precedência dos operadores:
      1. parênteses (qualquer coisa que estiver dentro do parênteses é executada primeiro)
      2. exponencial
      3. multiplicação e divisão (da esquerda pra direita)
      4. adição e subtração (da esquerda pra direita)
      */

      int value1 = 3 + 4 * 5;
      int value2 = (3 + 4) * 5;
      Console.WriteLine(value1);
      Console.WriteLine(value2);
    }
  }
}