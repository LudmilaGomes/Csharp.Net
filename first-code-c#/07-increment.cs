using System;

namespace Increment
{
  class MainClass
  {
    public static void Main()
    {
      int value = 0;
      Console.WriteLine(value); // 0
      value++;
      Console.WriteLine(value); // 1
      value++;
      Console.WriteLine(value); // 2
      value += 5;
      Console.WriteLine(value); // 7
      /*
      Operadores como +=, -=, *=, ++ e -- são conhecidos como operadores de atribuição compostos 
      porque eles compõem alguma operação além de atribuir o resultado à variável.
      */

      value = 1;                                   // 1
      value = value + 1;
      Console.WriteLine("First increment: " + value);  // 2
      value += 1;
      Console.WriteLine("Second increment: " + value); // 3
      value++;
      Console.WriteLine("Third increment: " + value);  // 4
      value = value - 1;
      Console.WriteLine("First decrement: " + value);  // 3
      value -= 1;
      Console.WriteLine("Second decrement: " + value); // 2
      value--;
      Console.WriteLine("Third decrement: " + value);  // 1

      /*
      Tanto o operador de incremento quanto o de decremento têm uma qualidade interessante — 
      dependendo de sua posição, eles realizam sua operação antes ou depois de recuperarem 
      seu valor. Em outras palavras, se você usar o operador antes do valor como em ++value, 
      então o incremento acontecerá antes que o valor seja recuperado. Da mesma forma, value++
      incrementará o valor depois que o valor tiver sido recuperado.
      */

      value = 1;
      value++;
      Console.WriteLine("First: " + value);     // 2
      // depois que o valor da variável value é retornado, ela é incrementada
      Console.WriteLine($"Second: {value++}");  // 2
      // value é exibida e então incrementada
      // aqui, value tem valor 3

      value = 1;
      value++;
      Console.WriteLine("Third: " + value);     // 2
      // antes que o valor da variável value seja retornado, ela é incrementada
      Console.WriteLine("Fourth: " + (++value));// 3
      // value é incrementada e então exibida

      // ========

      int fahrenheit = 94;
      // decimal celsius = (fahrenheit - 32) * (5/9); // resultado é 0 devido à operação de divisão com números inteiros
      decimal celsius = (fahrenheit - 32) * (5m/9);
      Console.WriteLine($"The temperature is {celsius} Celsius.");
    }
  }
}