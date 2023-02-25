using System;
namespace Amaliy_kalkul.classes

{
    class Security
    {
        public void CheckPassword()
        {
             string password = "";
            do  
            {
            System.Console.WriteLine("Enter password");
            password = Console.ReadLine();
            }
            while(password != "123"); 
        }
    }
}