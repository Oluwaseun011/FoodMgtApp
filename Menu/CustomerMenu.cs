using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodMgtApp.Services.Interfaces;

namespace FoodMgtApp.Menu
{
    public partial class MainMenu
    {
        ICustomerService customerService = new CustomerService();
        public void CustomerMenu()
        {
            Console.Write("1. Fund Wallet\n2. Create Order\n3. View orders\n#. Exit");
            string option = Console.ReadLine();

            if (option == "1")
            {
                FundWalletMenu();
                CustomerMenu();
            }
            else if (option == "2")
            {
                
            }
            else if (option == "3")
            {
                
            }
            else if (option == "#")
            {
                
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }

        public void FundWalletMenu()
        {
            Console.WriteLine("Enter amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            var response = customerService.FundWallet(amount);
            Console.WriteLine($"Wallet funded successfully\nYour new balance is {response}");
        }

        public void CreateOrderMenu()
        {
            
        }
    }
}