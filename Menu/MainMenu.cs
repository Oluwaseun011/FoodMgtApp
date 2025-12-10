using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Dtos;
using FoodDeliveryApp.Models.Entities;
using FoodDeliveryApp.Services.Implementations;
using FoodDeliveryApp.Services.Interfaces;
using FoodMgtApp.Dtos;
using FoodMgtApp.Models.Enums;
using FoodMgtApp.Services.Interfaces;

namespace FoodDeliveryApp.Menu
{
    public partial class MainMenu 
    {
        IUserService userService = new UserService();
        IKitchenService kitchenService = new KitchenService();
        public void Start()
        {
            Console.Write("1. Register\n2. Login\n3. Exit");
            string opt = Console.ReadLine()!;
            if(opt == "1")
            {
                RegisterMenu();
                Start();
            }
            else if(opt == "2")
            {
                LoginMenu();
            }
            else
            {
                Console.WriteLine("Thank you");
                Start();
            }
        }

        public void RegisterMenu()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Select State: 1. Lagos\n2. Ogun\n.3. Oyo");
            State state = (State)int.Parse(Console.ReadLine());
            
            KitchenRequest kitchenRequest = new KitchenRequest(name, email, password, description);
            var response = kitchenService.RegisterKitchen(kitchenRequest);
            if(response is null)
            {
                Console.WriteLine("Registration failed");
            }
            else
            {
                Console.WriteLine("Registration successful");
            }
        }

        public void LoginMenu()
        {
            Console.Write("Email");
            string email = Console.ReadLine();
            Console.Write("Password");
            string password = Console.ReadLine();

            LoginRequest loginRequest = new LoginRequest(email, password);
            var response = userService.Login(loginRequest);
            if (response is null)
            {
                Console.WriteLine("Login failed");
            }
            else
            {
                
            }
        }
    }
}