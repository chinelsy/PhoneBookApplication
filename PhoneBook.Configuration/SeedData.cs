using PhoneBook.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;

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


        private readonly List<Contact> _contact;
        public List<Contact> CheckDuplicate(string field) 
        {
            var seedData = new SeedData();
            List<Contact> list = new List<Contact>() { 
                new Contact() { Name = "Chikkito", Number = "07036842879" },
                new Contact() { Name = "Jikkito", Number= "08036842879" },
                new Contact() { Name = "Haco", Number = "09036842879" } ,
                new Contact() { Name ="Lucy", Number = "07047842879"},
                new Contact() { Name = "Ben",  Number = "07046842879" }
            };
            
            var duplicateName = seedData.CheckDuplicate("name");
            var duplicateNumber = seedData.CheckDuplicate ("number");
               

            foreach (var dupName in duplicateName)
            {
                var name = Console.ReadLine();
                var contact = _contact.FirstOrDefault(c => c.Name == name);
                if (list.Contains(dupName))
                {
                    list.Remove(dupName);
                }  
                else
                {
                    duplicateName.Add(dupName);
                }
                Console.WriteLine(dupName);
            }

            foreach (var dupnum in duplicateNumber)
            {
                var number = Console.ReadLine();
                var contact = _contact.FirstOrDefault(c => c.Number == number);
                if (list.Contains(dupnum))
                {
                    list.Remove(dupnum);
                }
                else
                {
                    duplicateNumber.Add(dupnum);
                }
                Console.WriteLine(dupnum); 
            }
           return list;
        }

    }
}
