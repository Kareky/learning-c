/*  IP Address Validation Exercise
    Write a program that checks whether an IPv4 address is valid or invalid. You're given the following rules:
    A valid IPv4 address consists of four numbers separated by dots
    Each number must not contain leading zeroes
    Each number must range from 0 to 255
*/
using System;

namespace IpAdressExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taking the IP address from the user
            if (!IPv4Address.TakeNew(out string ipAdress))
            {
                Console.WriteLine("No IP Address entered. Please insert a valid IP Address.");
                return;
            }

            IPv4Address.VerifyIP(ipAdress);
        }
    }

    public class IPv4Address
    {
        //Method that take the IP address from the user
        //For now it works with console input only
        //It return false if the input is empty
        internal static bool TakeNew(out string ipAdress)
        {
            Console.WriteLine("Enter an IPv4 address to validate:");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                ipAdress = "";
                return false;
            }
            ipAdress = input;
            return true;
        }

        //Method that verify if the IP address is valid or not
        //It prints the result to the console
        internal static void VerifyIP(string ipAdress)
        {
            //Validating the IP address
            if (!IPv4Address.SplitIP(ipAdress, out string[] parts))
            {
                Console.WriteLine("Invalid IP Address: the format of the IP address is incorrect. Verify and try again");
                return;
            }

            foreach (string part in parts)
            {
                if (!IPv4Address.ValidateLeadingZeroes(part) || !IPv4Address.ValidateRange(part))
                {
                    Console.WriteLine("Invalid IP Address: one or more parts of the IP address are incorrect. Verify and try again");
                    return;
                }
            }

            Console.WriteLine("The IP Address is valid");
        }

        //Method that split the IP address into its four parts
        //It return false if the IP doesn't have 4 parts
        private static bool SplitIP(string ipAdress, out string[] parts)
        {
            parts = ipAdress.Split('.', StringSplitOptions.RemoveEmptyEntries);
            return parts.Length == 4;
        }

        //Method that check if an IPv4 part have leading zeroes
        private static bool ValidateLeadingZeroes(string part)
        {
            if (part.StartsWith('0') && part.Length > 1)
                return false;
            return true;
        }
        //Method that validate if a single part of a IPv4 is between 0 and 255
        //The method return false if conditions aren't met
        private static bool ValidateRange(string part)
        {    
            if (!int.TryParse(part, out int digit))
                return false;
            
            if (digit < 0 || digit > 255)
                return false;

            return true;
        } 
    }
}