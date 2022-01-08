using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUser
{
    public class DeleteContact
    {

        //what to do
        // we will take the first name from the user
        //than iterate in our addressBook for that contact name
        // if found than remove it otherwise print user the msg
        public static void deleteContact()
        {
            Console.WriteLine("Enter the first name of the person whose contact you want to delete from the addressbook");
            string deleteKey = Console.ReadLine();
            int flag = 0;

            // count the entity in addressBook
            if (AddressBookMain.addressBook.Count > 0)
            {
                foreach (Contact contact in AddressBookMain.addressBook)
                {
                    if (deleteKey.ToLower() == contact.firstName.ToLower())
                    {
                        flag = 1;
                        AddressBookMain.addressBook.Remove(contact);
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine("Your address book is empty");
            }
            if (flag == 0)
            {

                Console.WriteLine("contact of the person {0} does not exist", deleteKey);
            }
        }
    }
}
