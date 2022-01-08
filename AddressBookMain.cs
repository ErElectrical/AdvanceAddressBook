using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUser
{
    // class is responsible for adding new contacts to the addressBook
    public class AddressBookMain
    {
        // a list to store our input data
        // type for list is our contact class which contains all neccessary fields
        public static List<Contact> addressBook = new List<Contact>();

        // Method To add contacts

        public static void Add()
        {
            Console.WriteLine("How many contacts do you want to add?");
            int contactsNum = Convert.ToInt32(Console.ReadLine());
            while (contactsNum > 0)
            {
                // create a instance for our contact class.
                Contact person = new Contact();

                // take input data from the user
                
                Console.WriteLine("Enter your First name");
                person.firstName = Console.ReadLine();
                Console.WriteLine("Enter your Last name");
                person.lastName = Console.ReadLine();
                Console.WriteLine("Enter your address");
                person.address = Console.ReadLine();
                Console.WriteLine("Enter your city");
                person.city = Console.ReadLine();
                Console.WriteLine("Enter your State");
                person.state = Console.ReadLine();
                Console.WriteLine("Enter your Zip code");
                person.ZipCode = Console.ReadLine();
                Console.WriteLine("Enter your Phone number");
                person.PhoneNunmber = Console.ReadLine();
                Console.WriteLine("Enter your Email ID");
                person.email = Console.ReadLine();

                // passing the values that are now stored in contact class to our list instance
                addressBook.Add(person);
                Console.WriteLine("{0}'s contact succesfully added", person.firstName);

                // decrement so that loop can run again
                contactsNum--;
            }
        }

        // Method responsible for Displaying AddressBook to the end user
        // what to do 
        // for display Address Book we will take input from the user about the person name which he want to fetch
        // and than search it by first name field .

        public static void ContactsDisplay()
        {
            if (addressBook.Count > 0)
            {
                Console.WriteLine("Enter the name of the person to get all the contact details");
                string namein = Console.ReadLine();
                foreach (Contact contact in addressBook)
                {
                    if (namein.ToLower() == contact.firstName.ToLower())
                    {
                        Console.WriteLine("First name-->{0}", contact.firstName);
                        Console.WriteLine("Last name-->{0}", contact.lastName);
                        Console.WriteLine("Address-->{0}", contact.address);
                        Console.WriteLine("City-->{0}", contact.city);
                        Console.WriteLine("State-->{0}", contact.state);
                        Console.WriteLine("Zip code-->{0}", contact.ZipCode);
                        Console.WriteLine("Phone number-->{0}", contact.PhoneNunmber);
                        Console.WriteLine("E-Mail ID-->{0}", contact.email);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("contact of the person {0} does not exist", namein);
                    }
                }
            }
            else
            {
                Console.WriteLine("Your address book is empty");
            }
        }

    }
}
