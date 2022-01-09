using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUser
{
    public class DuplicateEntity
    {

        //what to do
        //we have to ensure that no duplicate entry should be entered in our addressBook
        //for that we will check the firstname in respective addressBook
        // entity can be duplictae but not in same addressBook
        public static bool NameDuplicationCheck(string addressBookName, string firstName)
        {
            int flag = 0;
            if (RefactorToAddMultipleAddressBook.mySystem[addressBookName].Count > 0)
            {
                foreach (Contact contact in RefactorToAddMultipleAddressBook.mySystem[addressBookName])
                {
                    if (!(contact.firstName == firstName))
                    {
                        flag = 1;
                        // if flag is 1 its mean that name is unique
                    }
                    else
                    {
                        flag = 0;
                        break;
                        //if flag is 0 its mean name is also prsent in the addressBook.
                    }
                }
            }
            else
            {
                return true;
            }
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
