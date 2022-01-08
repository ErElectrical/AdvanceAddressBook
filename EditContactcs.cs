
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUser
{
    public class EditContact
    {

        // what to do and how to do
        //  we will take input from the user about which name he want to edit
        // than we will check it in our addressBook the name exist or not
        // If exist than we will change it otherwise display msg to user

        public static void Editcontact()
        {
            Console.WriteLine("Enter the first name of the person whoom you want to edit the details");
            string editKey = Console.ReadLine();
            if (AddressBookMain.addressBook.Count > 0)
            {
                foreach (Contact contact in AddressBookMain.addressBook)
                {
                    if (editKey.ToLower() == contact.firstName.ToLower())
                    {
                        Console.WriteLine("Enter the key number for editing the details\n 1. First name\n 2. Last name\n 3. Address\n 4. City\n 5. State\n 6. Zipcode\n 7. Phone number\n 8. Email ID");
                        int key = Convert.ToInt32(Console.ReadLine());
                        switch (key)
                        {
                            case 1:
                                Console.WriteLine("Enter the new First name");
                                contact.firstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the new Last name");
                                contact.lastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter the new address");
                                contact.address = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter the new city");
                                contact.city = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter the new state");
                                contact.state = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter the new zip code");
                                contact.ZipCode = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter the new phone");
                                contact.PhoneNunmber = Console.ReadLine();
                                break;
                            case 8:
                                Console.WriteLine("Enter the new E-Mail ID");
                                contact.email = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Please enter a valid input");
                                Editcontact();
                                break;
                        }
                        Console.WriteLine("{0}'s contact has been sucessfully added", editKey);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("contact of the person {0} does not exist", editKey);
                        break;
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