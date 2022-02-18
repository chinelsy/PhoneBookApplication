using System;

namespace PhoneBook.View
{
    public static class LoginScreen
    {
        public static void RunScreen()
        {
            Console.WriteLine("WELCOME\n");
            Console.WriteLine("Select Operation\n");
            Console.WriteLine("1. Add Contact\n");
            Console.WriteLine("2. Get all contacts\n");
            Console.WriteLine("3. Display contact by number\n");
            Console.WriteLine("4. Update a contact\n");
            Console.WriteLine("5. Search for contact by name phrase\n");
            Console.WriteLine("6. Delete a Contact\n");
            Console.WriteLine("Press 'x' to exit\n");
        }
    }
}
