using PhoneBook.Entities.Model;
using System.Collections.Generic;

namespace PhoneBook.Repository
{
    public interface IEntryContact<T>
    {
        void AddContact(T contact);
        void DisplayContact(string number);
        void DisplayContacts();
        void DisplayMatchingContacts(string searchPhrase);
        void UpdateContact(int id);
        void RemoveContact(string name);
        IEnumerable<Contact> Contacts();
    }
}
  