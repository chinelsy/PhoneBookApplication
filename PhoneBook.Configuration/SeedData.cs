using PhoneBook.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook.Configuration
{
    public class SeedData
    {
        static List<Contact> Contacts = new List<Contact>()
            {
                 new ()
                 {
                    Id = 1,
                    Name = "Chikkito",
                    Number = "07036842879"
                 },

                new ()
                {
                    Id = 2,
                    Name = "Jikkito",
                    Number = "08036842879"
                },

                new ()
                {
                    Id = 3,
                    Name = "Haco",
                    Number = "09036842879"
                },

                new ()
                {
                    Id = 4,
                    Name = "Lucy",
                    Number = "07047842879"
                },

                new Contact()
                {
                    Id = 5,
                    Name = "Ben",
                    Number = "07046842879"
                }

            };
        public static IEnumerable<Contact> GetAllContacts()
        {
            return Contacts;
        }

        public static bool IsDuplicate(string name, string number)
        {
            var contacts = GetAllContacts();
            var contact = contacts.FirstOrDefault(c => c.Name.ToLower() == name.ToLower() || c.Number == number);
            if (contact is null)
            {
                return false;
            }
            else
            {
                Console.WriteLine("The contact already exist");
                return true;
            }
            
        }
    }
}
