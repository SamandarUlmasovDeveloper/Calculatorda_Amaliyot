using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amaliy_kalkul.classes
{
    public class Calculator
    {
        
    
        public int FirstNumber  { get; set; }
        public int SecondNumber{ get; set; }
        public string Operation { get; set; }

        public void GetInputs()
        {
            
            Console.WriteLine("Type 1st number");
            FirstNumber =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter operation(+,-,/,*,%):");
            Operation = Console.ReadLine();
            Console.WriteLine("Type 2nd number");
            SecondNumber =Convert.ToInt32(Console.ReadLine());
        }

        public bool IsFirstNumberPositive()
        {
           return FirstNumber >= 0;
        }

        public void CompareInputs()
        {
               if(FirstNumber > SecondNumber){
             System.Console.WriteLine("1st number is greater than 2nd number");

            }

            else if(FirstNumber == SecondNumber)
            {
                System.Console.WriteLine("1st number is equal to 2nd number");
            }
            else
            {
                System.Console.WriteLine("1st number is less than 2nd number");
            }
        }

        public string  calculate()
        {
            return Operation switch
                {
                "-"=>  $" {FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "+" => $" {FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "/"=>  $" {FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                _   => "Operation not found!"  
                
                };
        }
        public void PrintEvenNubers()
        {
                Console.WriteLine("Printing even numbers till first input...");
                int counter = 2;
                while(counter <FirstNumber)
                {
                    Console.WriteLine(counter);
                    counter += 2;
                }
        }
        public void MultipicilationTable()
        {
            for(int itarator = 1; itarator <= 10; itarator++)
                {
            for( int innerItarator = 1; innerItarator <= 10; innerItarator++)
                   {
                     Console.WriteLine($"{itarator} x {innerItarator} = {itarator * innerItarator}");
                   }
                   Console.WriteLine("\n");
            }
        }
    }
}
    
