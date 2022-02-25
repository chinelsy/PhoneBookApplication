namespace PhoneBook.Repository
{
    public interface IEntryContact<T>
    {
        void AddContact(T contact);
        void GetAllContacts();
        void UpdateContact(int id);
        void RemoveContact(string name);
        int GetLastContactById(); 
    }
}
