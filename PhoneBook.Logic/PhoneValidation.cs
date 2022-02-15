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
            // var phoneContacts = new PhoneContacts();
            Console.WriteLine("Contact number");
            var number = Console.ReadLine();

            if (string.IsNullOrEmpty(number))
            {
                //return false;
                Console.WriteLine($"{field} cannot be empty, Re-enter your {field}");
                return null;
            }
            else if (number.Any(n => char.IsLetter(n)) || number.Length != 11)
            {
                Console.WriteLine($"{field} cannot contain letters but numbers only and cannot be less than or more than 11, Re-enter your {field}");
                return null;
            }
            return number;

        }
    }

}

// FOR NAME

/*  public static void EmptyPrompt(string field)
       {
           Console.WriteLine($"{field} cannot be empty, Re-enter your {field}");
       }

       public static void LessThanTwoPrompt(string field)
       {
           Console.WriteLine($"{field} cannot be less than 2 characters, Re-enter your {field}");
       }

       public static void ContainsNumber(string field)
       {
           Console.WriteLine($"{field} cannot contain nmbers, Re-enter your {field}");
       }*/

//FOR NUMBER
/*else if (number.Any(n => char.IsLetter(n)))
            {
                Console.WriteLine($"{field} cannot contain letters but numbers only, Re-enter your {field}");
            }*/

/* foreach (var item in number)
 {
     //if any item is a letter return false and
     //if any string is not 11 return false
     if (char.IsLetter(item) || number.Length != 11) 
     {
         return false;
         //Console.WriteLine($"{field} cannot contain letter/s, Re-enter your {field}");
     }
     *//*else
     {
         Console.WriteLine($"{field} cannot contain number less than or greater than 11, Re-enter your {field}");
     }*//*
 }
 return true;
*/