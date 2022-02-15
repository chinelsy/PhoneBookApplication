using PhoneBook.Entities.Model;
using System.Collections.Generic;

namespace PhoneBook.Configuration
{
    public class SeedData
    {
        public static IEnumerable<Contact> Contacts()
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
                    Name = "Ken",
                    Number = "07046842879"
                }

            };

        }

        //Create a method for GetContact
        //public static IList<Contact> GetContact() => _contact;

    }
}

