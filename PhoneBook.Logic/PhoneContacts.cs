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
        private  readonly List<Contact> _contact;
        private static void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact:{contact.Id}, {contact.Name}, {contact.Number}");

        }
        public PhoneContacts()
        {
            _contact = new List<Contact>();
        }
        public void AddContact(Contact contact) => _contact.Add(contact);

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

        public void DisplayContacts()
        {
            foreach (var contact in _contact)
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

        public void RemoveContact(string name)
        {
            var contactToRemove = _contact.AsEnumerable().Where
                (c => c.Name == name).First();
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

        public IEnumerable<Contact> Contacts()
        {
            //var result = _contact.AsEnumerable().ToList();
            return SeedData.Contacts();

        }


    }
}
