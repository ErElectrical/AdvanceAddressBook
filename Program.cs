﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookUser
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Address Book for User");
            AddressBookMain.Add();
            AddressBookMain.ContactsDisplay();
            Console.WriteLine("before edit ----------------------------------------------------------------------");
            EditContact.Editcontact();
            Console.WriteLine("After edit");
            Console.WriteLine("-------------------------------------------------------------------------------");
            AddressBookMain.ContactsDisplay();


        }
    }
}
