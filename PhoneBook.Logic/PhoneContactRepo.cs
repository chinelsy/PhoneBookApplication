using PhoneBook.Configuration;
using PhoneBook.Entities.Model;
using PhoneBook.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook.Logic
{
    public class PhoneContactRepo : IPhoneContactRepo<Contact>
    {
        private readonly List<Contact> _contact;
        private static void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact:{contact.Id}, {contact.Name}, {contact.Number}");

        }
        public PhoneContactRepo()
        {
            _contact = SeedData.GetAllContacts().ToList();
        }
        public void DisplayContact(string number)
        {
            var contact = _contact.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        //This method searches for a given contact by Alphbate
        //named: bobo
        //searchphrase: b
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContact = _contact.Where(c => c.Name.Contains(searchPhrase)).ToList();
            foreach (var contact in matchingContact)
            {
                DisplayContactDetails(contact);
            }
        }
    }
}