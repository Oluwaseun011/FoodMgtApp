using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Menu
{
    public partial class MainMenu
    {
        public void CeoMenu()
        {
            Console.Write("1. Kitcken Mgt\n2. User Mgt\n3. Exit");
            string opt = Console.ReadLine()!;
            if (opt == "1")
            {
            }
            else if (opt == "2")
            {
            }
            else
            {
                Console.WriteLine("Thank you");
                CeoMenu();
            }
        }
    }
}