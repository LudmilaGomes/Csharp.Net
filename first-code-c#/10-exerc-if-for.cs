using System;

namespace Exerc
{
  class MainClass
  {
    public static void Main()
    {
      /*
      Sophia: 93, 87, 98, 95, 100
      Nicolas: 80, 83, 82, 88, 85
      Zahirah:   84, 96, 73, 85, 79
      Jeong:  90, 92, 98, 100, 97
      */
      int[] sophia = {93, 87, 98, 95, 100};
      decimal sophiaScore = 0;

      int[] nicolas = {80, 83, 82, 88, 85};
      decimal nicolasScore = 0;

      int[] zahirah = {84, 96, 73, 85, 79};
      decimal zahirahScore = 0;

      int[] jeong = {90, 92, 98, 100, 97};
      decimal jeongScore = 0;
      
      foreach (int item in sophia)
      {
        sophiaScore += item;
      }

      foreach (int item in nicolas)
      {
        nicolasScore += item;
      }

      foreach (int item in zahirah)
      {
        zahirahScore += item;
      }

      foreach (int item in jeong)
      {
        jeongScore += item;
      }

      string[] names = {"Sophia", "Nicolas", "Zahirah", "Jeong"};
      decimal[] scores = {sophiaScore, nicolasScore, zahirahScore, jeongScore};

      Console.Write("Student\t\tGrade\n");
      for (int i = 0; i < names.Length; i++)
      {
        for (int j = 0; j < scores.Length; j++)
        {
          if (i == j)
          {
            Console.Write($"{names[i]}\t\t{scores[j] / 5m}  ");

            /*
            97 - 100    A+
            93 - 96     A
            90 - 92     A-
            87 - 89     B+
            83 - 86     B
            */

            if ((scores[j] / 5m) >= 97 && (scores[j] / 5m) <= 100)
              Console.Write("A+\n");
            else if ((scores[j] / 5m) >= 93 && (scores[j] / 5m) <= 96)
              Console.Write("A\n");
            else if ((scores[j] / 5m) >= 90 && (scores[j] / 5m) <= 92)
              Console.Write("A-\n");
            else if ((scores[j] / 5m) >= 87 && (scores[j] / 5m) <= 89)
              Console.Write("B+\n");
            else if ((scores[j] / 5m) >= 83 && (scores[j] / 5m) <= 86)
              Console.Write("B\n");

            
          }
        }
      }
    }
    /*
    Student     Grade
    Sophia      94.6  A
    Nicolas     83.6  B
    Zahirah     83.4  B
    Jeong       95.4  A
    */
  }
}