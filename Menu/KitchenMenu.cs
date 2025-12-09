using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodMgtApp.Dtos;

namespace FoodMgtApp.Menu
{
    public partial class MainMenu
    {
        public void KitchenCeo()
        {
            Console.Write("1. Register Kitchen\n2. View Kitchen details\n3. View All Kitchens\n#. Exit");
            string option = Console.ReadLine()!;
            if (option == "1")
            {
                RegisterKitchenMenu();
                KitchenCeo();
            }
            else if (option == "2")
            {
                ViewKitchenMenu();
                KitchenCeo();
            }
            else if (option == "3")
            {
                ViewAllKitchenMenu();
                KitchenCeo();
            }
            else if (option == "#")
            {
                Console.WriteLine("Exit");
                Start();
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }

        public void RegisterKitchenMenu()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();

            KitchenRequest kitchenRequest = new KitchenRequest(name, email, password, description);
            var response = kitchenService.Register(kitchenRequest);
            if(response is null)
            {
                Console.WriteLine("Kitchen already exists");
            }
            else
            {
                Console.WriteLine("Kitchen created successfully");
            }
        }

        public void ViewKitchenMenu()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            
            var response = kitchenService.GetKitchen(name);
            if (response is null)
            {
                Console.WriteLine("Kitchen does not exist");
            }
            else
            {
                Console.WriteLine($"{response.Id}\t{response.Name}\t{response.Description}");
            }
        }

        public void ViewAllKitchenMenu()
        {
            var kitchens = kitchenService.GetAllKitchens();
            if (kitchens.Count == 0)
            {
                Console.WriteLine("No Kitchen found");
            }
            else
            {
                Console.WriteLine($"{kitchens.Name}\n{kitchens.Description}");
            }
        }
    }
}