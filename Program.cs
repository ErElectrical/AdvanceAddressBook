using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookUser
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Address Book for User");
            Console.WriteLine("choose the option you want to do with addressBook" +
                "\n choose 1 for Add contact" +
                  "\n choose 2 for Edit contact" +
                  " \n choose 3 for Delete Contacts" +
                  "\n choose 4 for add multiple addressBook" +
                  "\n choose 5 for see AddressBook" +
                  "\n choose 6 for search Person" +
                  "\n choose 7 for count person by city and state " +
                  "\n choose 8 for Sort Person By firstname"+
                  "\n choose 9 for sort person by city"+
                  "\n choose 10 for Csv File Handling"+
                  "\n Press 11 to exit ");
                  
            int option =Convert.ToInt32( Console.ReadLine());

            switch(option)
            {
                case 1:
                    {
                        AddressBookMain.Add();
                        AddressBookMain.ContactsDisplay();
                        break;
                    }
                case 2:
                    {
                        EditContact.Editcontact();
                        AddressBookMain.ContactsDisplay();
                        break;
                    }
                case 3:
                    {
                        DeleteContact.deleteContact();
                        AddressBookMain.ContactsDisplay();

                        break;

                    }
                case 4:
                    {
                        RefactorToAddMultipleAddressBook.addAddressBook();
                        Console.WriteLine("choose option that you want to do with multiple addressBook");
                        Console.WriteLine("1. AddContact" +
                            "\n 2. ContactDisplay" +
                            "\n 3. EditContact" +
                            "\n 4. DeleteContact" );
                        int x = Convert.ToInt32(Console.ReadLine());
                        switch(x)
                        {
                            case 1:
                                {
                                    Console.WriteLine("enter addressBook Name");
                                    string address = Console.ReadLine();
                                    RefactorToAddMultipleAddressBook.AddContact(address);
                                    break;
                                }
                            case 2:
                                {
                                    RefactorToAddMultipleAddressBook.ContactsDisplay();
                                    break;
                                }
                            case 3:
                                {
                                    RefactorToAddMultipleAddressBook.EditContact();
                                    break;
                                }
                            case 4:
                                {
                                    RefactorToAddMultipleAddressBook.DeleteContact();
                                    break;
                                }

                        }
                            
                        
                        break;
                    }
                case 5:
                    {
                        AddressBookMain.ContactsDisplay();
                        break;
                    }
                case 6:
                    {
                        SearchPerson.PersonSearch();
                        break;
                    }
                case 7:
                    {
                        CountContact.CountByStateCity();
                        break;
                    }
                case 8:
                    {
                        sortByName.sortbyFirstName();
                        break;
                    }
                case 9:
                    {
                        SortByCity.SortBycity();
                        break;
                    }
                case 10:
                    {
                        CsvFile.CsvHandle();
                        break;
                    }
                case 11:
                    {
                        AddressBookMain.ExitProgram();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Dont try to play with developer ");
                        break;
                    }
            }

        }
    }
}

