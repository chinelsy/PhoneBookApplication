namespace PhoneBook.Repository
{
    public interface IEntryContact<T>
    {
        void AddContact(T contact);
        void DisplayContact(string number);
        //void DisplayContacts();
        void GetAllContacts();
        void DisplayMatchingContacts(string searchPhrase);
        void UpdateContact(int id);
        void RemoveContact(string name);   
    }
}
