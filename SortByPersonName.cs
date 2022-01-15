using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUser
{
    public class DummyContact:Contact,IComparable<DummyContact>
    {
        public int CompareTo(DummyContact obj)
        {
            return firstName.CompareTo(obj.firstName);

        }


    }

    public class sortByName
    {
        public static void sortbyFirstName()
        {
            Console.WriteLine("before sorting ");
            foreach(var item in AddressBookMain.addressBook)
            {
                Console.WriteLine("First Name : {0} ", item.firstName);
                Console.WriteLine("Last Name  : {0} ", item.lastName);
                Console.WriteLine("Phonenumber  : {0} ", item.PhoneNunmber);
                Console.WriteLine("Address : {0} ", item.address);
                Console.WriteLine("Email id  : {0} ", item.email);
                Console.WriteLine("city : {0} ", item.city);
                Console.WriteLine("state : {0} ", item.state);






            }
            DummyContact dum = new DummyContact();
            AddressBookMain.addressBook.Sort();

            Console.WriteLine("After sorting ");
            foreach (var item in AddressBookMain.addressBook)
            {
                Console.WriteLine("First Name : {0} ", item.firstName);
                Console.WriteLine("Last Name  : {0} ", item.lastName);
                Console.WriteLine("Phonenumber  : {0} ", item.PhoneNunmber);
                Console.WriteLine("Address : {0} ", item.address);
                Console.WriteLine("Email id  : {0} ", item.email);
                Console.WriteLine("city : {0} ", item.city);
                Console.WriteLine("state : {0} ", item.state);






            }



        }

    }




}
