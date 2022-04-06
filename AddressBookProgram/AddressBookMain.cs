using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    class AddressBookMain
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Enter 1 to Add Contact");
            int enterKey = Convert.ToInt32(Console.ReadLine());
            switch (enterKey)
            {
                case 1:
                    Contacts.AddContacts();
                    break;
                default:
                    Console.WriteLine("Wrong Key. Try once more\n");
                    AddressBookMain.Main();
                    break;
            }
        }

    }
}