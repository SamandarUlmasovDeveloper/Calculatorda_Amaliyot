
using System;
using  Amaliy_kalkul.classes;
internal class Program
   {
      public static void Main(string[] args)
     {
        Security security = new Security();
        Calculator calculator = new Calculator();
        security.CheckPassword();
        calculator.GetInputs();

          string message =
          !(calculator.IsFirstNumberPositive())
          ? " 1st  number is not positive"
          : " 1st  number  not negative";
          
          System.Console.WriteLine(message);

          calculator.CompareInputs();
          
          string result =  calculator.calculate();

          Console.WriteLine(result);
          calculator.PrintEvenNubers();
          calculator.MultipicilationTable();
      }
   }
 