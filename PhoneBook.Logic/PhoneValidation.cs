using PhoneBook.Configuration;
using System;
using System.Linq;

namespace PhoneBook.Logic
{
    public static class PhoneValidation
    {
        //Donot leave any option blank
        //Validation for Name

        public static string ConfirmNameValidation(string field)
        {
            Console.WriteLine("Contact name");
            var name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"{field} cannot be empty, Re-enter your {field}");
                return null;
            }
            else if (name.Length < 2)
            {
                Console.WriteLine($"{field} cannot be less than 2 characters, Re-enter your {field}");
                return null;
            }
            else if (name.Any(n => char.IsDigit(n)))
            {
                Console.WriteLine($"{field} cannot contain numbers, Re-enter your {field}");
                return null;
            }
            return name;
        }

        //Donot leave any option blank
        //Validation for Number
        public static string ValidatePhoneNumber(string field)
        {
            Console.WriteLine("Contact number");
            var number = Console.ReadLine();

            if (string.IsNullOrEmpty(number))
            {
                Console.WriteLine($"{field} cannot be empty, Re-enter your {field}");
                return null;
            }
            else if (number.Any(n => char.IsLetter(n)) || number.Length != 11)
            {
                //return false;
                Console.WriteLine($"{field} cannot contain letters but numbers only and cannot be less than or more than 11, Re-enter your {field}");
                return null;
            }
            //return true;
            return number;
        }
       /* public static bool CheckDuplicate(string name, string number)
        {
            //var seedData = new SeedData();
            var contacts = GetAllContacts();
            var contact = contacts.FirstOrDefault(c => c.Name == name || c.Number == number);
            if (contact is null)
            {
                return false;
            }
            else
            {
                return true;
            }
            // Console.WriteLine(name, number);
            
        }

        private static object GetAllContacts()
        {
            throw new NotImplementedException();
        }*/
    }
}