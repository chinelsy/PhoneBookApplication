using PhoneBook.Entities.Model;
using PhoneBook.Logic;
using PhoneBook.Repository;
using PhoneBook.View;

namespace PhoneBook
{
    class Program
    { 
        static void Main(string[] args)
        {
            LoginScreen.RunScreen();
            IEntryContact<Contact> contact = new PhoneContacts();
            IPhoneContactRepo<Contact> contactRepo = new PhoneContactRepo(); ;
            var application = new Application(contact, contactRepo);
            application.RunApplication();
           
           
        }  
    }
}