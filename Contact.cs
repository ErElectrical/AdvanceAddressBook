using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUser
{
     public class Contact
    {

        // the contact class has all required field 
        // and we use accessor to fill there values

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNunmber { get; set; }
        public string email { get; set; }

    }
}
