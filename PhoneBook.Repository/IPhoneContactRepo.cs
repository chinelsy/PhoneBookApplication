namespace PhoneBook.Repository
{
    public interface IPhoneContactRepo<T>
    {
        void DisplayContact(string number);
        //void DisplayContacts();
        void DisplayMatchingContacts(string searchPhrase);
    }
}
 