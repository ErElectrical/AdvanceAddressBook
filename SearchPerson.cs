using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUser
{
    public class SearchPerson
    {
        public static void PersonSearch()
        {

            //what to do
            //search a person by his state or city name .

            //we will create two instance of dictionary in value of this list
            //is our contact list(addressBook store)
            Dictionary<string, List<Contact>> cityPersons = new Dictionary<string, List<Contact>>();
            Dictionary<string, List<Contact>> statePerson = new Dictionary<string, List<Contact>>();

            // take city name so that we will further use it as a key for our dictionary
            Console.WriteLine("Enter the city that you want to search");
            string cityKey = Console.ReadLine();

            // we fetch the data into cityPerson dictionary the data present in cityPerson dictionary is those
            //persons which belongs to same city
            cityPersons[cityKey] = new List<Contact>();


            //// we fetch the data into statePerson dictionary the data present in statePerson dictionary is those
            //persons which belongs to same state

            Console.WriteLine("Enter the state that you want to search");
            string stateKey = Console.ReadLine();
            statePerson[stateKey] = new List<Contact>();

            //outer loop is to fetch the addressBook name as we have multiple addressBook available in mysystem.
            foreach (string addressBookName in RefactorToAddMultipleAddressBook.mySystem.Keys)
            {
                // inner loop is to iterate the data present in addressBook
                foreach (Contact contact in RefactorToAddMultipleAddressBook.mySystem[addressBookName])
                {
                    if (cityKey.ToLower() == contact.city)
                    {
                        // if the data iterate is same of same city which we require than we put that data into cityPerson dictionary
                        cityPersons[cityKey].Add(contact);
                    }
                    else if (stateKey.ToLower() == contact.state)
                    {
                        // if state is same than put the contact into statePerson dictionary
                        statePerson[stateKey].Add(contact);
                    }
                }
            }
            // call the function by passing the parameter
            PersonSearchDisplay(cityPersons, statePerson, cityKey, stateKey);
        }

        public static void PersonSearchDisplay(Dictionary<string, List<Contact>> cityPersons, Dictionary<string, List<Contact>> statePersons, string cityKey, string stateKey)
        {

            // funation is responsible for displaying the data to the user
            Console.WriteLine("------------------- Persons in {0} city-------------------------", cityKey);
            foreach (Contact contact in cityPersons[cityKey])
            {
                Console.WriteLine("{0}", contact.firstName);
            }
            Console.WriteLine("--------------------Persons in {0} state", stateKey);
            foreach (Contact contact in statePersons[stateKey])
            {
                Console.WriteLine("{0}", contact.firstName);
            }
        }
    }
}
