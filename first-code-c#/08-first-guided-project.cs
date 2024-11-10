using System;

namespace Project
{
  class MainClass
  {
    public static void Main()
    {
      // initialize variables - graded assignments 
      int currentAssignments = 5;

      string stud1 = "Sophia";
      int sophia1 = 93;
      int sophia2 = 87;
      int sophia3 = 98;
      int sophia4 = 95;
      int sophia5 = 100;
      
      string stud2 = "Nicolas";
      int nicolas1 = 80;
      int nicolas2 = 83;
      int nicolas3 = 82;
      int nicolas4 = 88;
      int nicolas5 = 85;

      string stud3 = "Zahirah";
      int zahirah1 = 84;
      int zahirah2 = 96;
      int zahirah3 = 73;
      int zahirah4 = 85;
      int zahirah5 = 79;

      string stud4 = "Jeong";
      int jeong1 = 90;
      int jeong2 = 92;
      int jeong3 = 98;
      int jeong4 = 100;
      int jeong5 = 97;

      Console.WriteLine("Student\t\tGrade");
      Console.WriteLine($"{stud1}\t\t{(sophia1 + sophia2 + sophia3 + sophia4 + sophia5)/5m}  A");
      Console.WriteLine($"{stud2}\t\t{(nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5)/5m}  B");
      Console.WriteLine($"{stud3}\t\t{(zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5)/5m}  B");
      Console.WriteLine($"{stud4}\t\t{(jeong1 + jeong2 + jeong3 + jeong4 + jeong5)/5m}  A");

      /*
      Student     Grade
      Sophia      94.6  A
      Nicolas     83.6  B
      Zahirah     83.4  B
      Jeong       95.4  A
      */
    }
  }
}