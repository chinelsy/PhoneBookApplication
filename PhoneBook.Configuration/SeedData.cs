using PhoneBook.Entities.Model;
using System;
using System.Collections.Generic;

namespace PhoneBook.Configuration
{
    public class SeedData
    {
        public static IEnumerable<Contact> GetAllContacts()
        {
            return new List<Contact>()
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
        }
        /*public static void CheckNameValidation()
        {
            HashSet<string> names = new HashSet<string> {
               "Chikkito",
               "Jikkito",
               "Haco",
               "Lucy",
               "Ben"
            };
            names.Add("");
            //duplicates are not added into collection.   
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }*/
    }
}
