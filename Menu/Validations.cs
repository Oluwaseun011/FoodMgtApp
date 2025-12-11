using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Enums;

namespace FoodDeliveryApp.Menu
{
    public partial class MainMenu
    {
        private string ReadEmail()
        {
            var emailInput = "";
            bool isValidEmail = false;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            while (!isValidEmail)
            {
                emailInput = Console.ReadLine();
                if (Regex.IsMatch(emailInput, emailPattern))
                {
                    isValidEmail = true;
                }
                else
                {
                    Console.Write("Invalid email format. Please enter a valid email: ");
                }
            }

            return emailInput;
        }

        private string ReadPassword()
        {
            var sb = new StringBuilder();
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Enter)
                    break;

                if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (sb.Length > 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    sb.Append(keyInfo.KeyChar);
                    Console.Write("*");
                }
            }
            return sb.ToString();
        }

        private DateTime ReadDate()
        {
            DateTime date = DateTime.MinValue;
            bool isValidDate = false;
            while (!isValidDate)
            {
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                {
                    isValidDate = true;
                }
                else
                {
                    Console.Write("Invalid date format. Please enter the date in dd/MM/yyyy format:");
                }
            }
            return date;
        }

        private Gender ReadGender()
        {
            Gender gender = Gender.Male;
            bool isValidGender = false;

            while (!isValidGender)
            {
                if (int.TryParse(Console.ReadLine(), out int genderInput) && (genderInput == 1 || genderInput == 2))
                {
                    gender = (Gender)genderInput;
                    isValidGender = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 1 for male or 2 for female:");
                }
            }
            return gender;
        }

    }
}