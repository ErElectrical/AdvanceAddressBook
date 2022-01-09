using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUser
{
    public class RefactorToAddMultipleAddressBook
    {

        //what to do
        //we have to maintain a dictionary for our addressbook


        // our dictionary for 
        public static Dictionary<string, List<Contact>> mySystem = new Dictionary<string, List<Contact>>();
        public static List<Contact> addressBook;

        public static void addAddressBook()
        {

            // What to do
            // this function is responsible for create a new addressBook if required By the user.
            // if user enter to add new addressBook than we will check it with a function
            // that validate that the addressBook name is pre exist in addressBook dictionary mysystem or not..
            // than we will add contacts in that pre exist addressBook
            int count = 2;
            while (count > 0)
            {
                Console.WriteLine("Do you want to add the contact in the existing addressbook or new addressbook\n Enter the number accordingly\n 1. New addressbook\n 2. Existing addressbook");
                int key = Convert.ToInt32(Console.ReadLine());
                if (key == 1)
                {
                    AddressBookNewNameValidator();
                }
                else if (key == 2)
                {
                    AddressBookExistingNameValidator();
                }
                count--;
            }
        }
        public static void AddressBookNewNameValidator()
        {
            // what todo
            // function check for the validation of the addressBook name 
            // if user Entered addressBookname is pre available in addressBook
            // than we will give a msg to the user
            //else we will create a addressBook .
            Console.WriteLine("Enter the new addressbook name\n");
            string addressBookName = Console.ReadLine();
            if (mySystem.ContainsKey(addressBookName))
            {
                Console.WriteLine("Please enter a new addressbook name. The name entered already exist");
                AddressBookNewNameValidator();
            }
            else
            {
                //make a key in dictionary based on user input 
                mySystem[addressBookName] = new List<Contact>();
                AddContact(addressBookName);
            }
        }
        public static void AddressBookExistingNameValidator()
        {

            //function is responsible when the user enters the existing addressBookname 
            //than we will validate user about entering a new addressBook name 
            // and create a addressBook name key in our dictionary Mysytem
            Console.WriteLine("Enter the Existing addressbook name\n");
            string addressBookName = Console.ReadLine();
            if (!mySystem.ContainsKey(addressBookName))
            {
                Console.WriteLine("Please enter a new addressbook name. The name entered already exist");
                AddressBookExistingNameValidator();
            }
            else
            {
                AddContact(addressBookName);
            }
        }
        public static void AddContact(string addressBookName)
        {

            // Function responsible for add contacts in our addressBook
            Console.WriteLine("How many person's contact details do you want to add?");
            int personNum = Convert.ToInt32(Console.ReadLine());
            while (personNum > 0)
            {
                Contact person = new Contact();

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

                // add into dictionary
                // with validate addressBookname and entry of contact person
                //key for dictionary is always unique
                mySystem[addressBookName].Add(person);
                Console.WriteLine("{0}'s contact succesfully added", person.firstName);

                personNum--;
            }
        }
        public static void ContactsDisplay()
        {

            // function that will display the contacts
            Console.WriteLine("Enter the name of the addressbook that you wants to use for displaying contacts");
            string addressBookName = Console.ReadLine();
            if (mySystem[addressBookName].Count > 0)
            {
                Console.WriteLine("Enter the name of the person to get all the contact details");
                string nameKey = Console.ReadLine();
                int flag = 0;
                foreach (Contact contact in mySystem[addressBookName])
                {
                    if (nameKey.ToLower() == contact.firstName.ToLower())
                    {
                        flag = 1;
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
                }
                if (flag == 0)
                {
                    Console.WriteLine("contact of the person {0} does not exist", nameKey);
                }
            }
            else
            {
                Console.WriteLine("Your address book is empty");
            }
        }
        public static void EditContact()
        {
            // function algorithum is same as previous defined editcontact function
            Console.WriteLine("Enter the name of the addressbook that you wants to use for editing contacts");
            string addressBookName = Console.ReadLine();
            Console.WriteLine("Enter the first name of the person whoom you want to edit the details");
            string editKey = Console.ReadLine();
            int flag = 0;
            if (mySystem[addressBookName].Count > 0)
            {
                // here we will fetch the data from the dictionary using key
                foreach (Contact contact in mySystem[addressBookName])
                {
                    if (editKey.ToLower() == contact.firstName.ToLower())
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the key number for editing the details\n 1. First name\n 2. Last name\n 3. Address\n 4. City\n 5. State\n 6. Zipcode\n 7. Phone number\n 8. Email ID\n 9. Exit editor");
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
                                case 9:
                                    flag = 1;
                                    break;
                                default:
                                    Console.WriteLine("Please enter a valid input");
                                    EditContact();
                                    break;
                            }
                            if (flag == 1)
                            {
                                break;
                            }
                        }
                        Console.WriteLine("{0}'s contact has been sucessfully updated", editKey);
                        break;
                    }
                }
                if (flag == 0)
                {

                    Console.WriteLine("contact of the person {0} does not exist", editKey);
                }
            }
            else
            {
                Console.WriteLine("Your address book is empty");
            }
        }
        public static void DeleteContact()
        {

            ///Delete contact algorithum is same as previous delete contact
            /////the difference is just simple that there we fetch data directly from the addressBook by taking first naem as 
            ///a base because we have only single addressBook to deal 
            /// here we will compare the first name from the addressBook tha user provide us 
            Console.WriteLine("Enter the name of the addressbook that you wants to use for Deleting contacts");
            string addressBookName = Console.ReadLine();
            Console.WriteLine("Enter the first name of the person whose contact you want to delete from the addressbook");
            string deleteKey = Console.ReadLine();
            int flag = 0;
            if (mySystem[addressBookName].Count > 0)
            {
                foreach (Contact contact in mySystem[addressBookName])
                {
                    if (deleteKey.ToLower() == contact.firstName.ToLower())
                    {
                        flag = 1;
                        addressBook.Remove(contact);
                        break;
                    }
                    else
                    {

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
    }
}
