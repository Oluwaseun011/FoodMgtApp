using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Menu
{
    public class MainMenu
    {
        public void Menu()
        {
            Console.WriteLine("1.Create Account\n2.Login\n3.Exit.");
            string opt = Console.ReadLine()!;
            if(opt == "1")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Email: ");
                string email = Console.ReadLine()!;
                Console.Write("PhoneNUmber: ");
                string PhoneNUmber = Console.ReadLine()!;
                Console.Write("Password: ");
                string Password = Console.ReadLine()!;
                
            }
            else if(opt == "2")
            {
                Console.Write("Email: ");
                string email = Console.ReadLine()!;
                Console.Write("Password: ");
                string Password = Console.ReadLine()!;
            }
            else
            {
                Console.WriteLine("Exited");
            }
        }
    }
}