using PhoneBook.Configuration;
using PhoneBook.Entities.Model;
using PhoneBook.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook.Logic 
{
    public class PhoneContacts : IEntryContact<Contact>
    {
        private readonly List<Contact> _contact;
        private static void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact:{contact.Id}, {contact.Name}, {contact.Number}");

        }
        public PhoneContacts()
        {
            _contact = SeedData.GetAllContacts().ToList();
        }

        public void AddContact(Contact contact)
        {
            _contact.Add(contact);
        }
        public void GetAllContacts()
        {
            foreach (var contact in _contact)
            {
                DisplayContactDetails(contact);
            }
        }

        public int GetLastContactById() 
        {
            var lastElemnt = _contact.Last();
            return lastElemnt.Id;
        }
        
        public void RemoveContact(string name)
        {
            var contactToRemove = _contact.AsEnumerable().Where
                (c => c.Name.ToLower() == name.ToLower()).First(); 
            _contact.Remove(contactToRemove);
        }

        public void UpdateContact(int id)
        {
            var contact = _contact.Where(c => c.Id == id).FirstOrDefault();
            if (contact == null)
            {
                Console.WriteLine("Contact not found for update");
            }
            else
            {
                Console.WriteLine($"Contact:{contact.Id}");
            }
        }
    }
}
          /*  public int GetLastContact() 
         {
             var lastElemnt = _contact.Last();
             return lastElemnt.Id;
         }
*/