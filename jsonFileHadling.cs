using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AddressBookUser
{
    public  class jsonFileHadling
    {
        public static  string import = @"C:\Users\as\Desktop\.net\AddressBookUser\Import.json";
        public  static string export = @"C:\Users\as\Desktop\.net\AddressBookUser\Export.json";

        public static void JsonReadwrite()
        {
            StreamReader r = new StreamReader(import);
            string json = r.ReadToEnd();
            Contact dx=JsonConvert.DeserializeObject<Contact>(json);

            foreach(Contact c in dx)
            {
                Console.WriteLine("FirstName :{0}", dx.firstName);
                Console.WriteLine("LastName : {0}", dx.lastName);
                Console.WriteLine("PhoneNumber : {0}", dx.PhoneNunmber);
                Console.WriteLine("Email : {0}", dx.email);
                Console.WriteLine("state : {0}", dx.state);




            }

            JsonSerializer serial = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(export))
            using (JsonWriter write = new JsonTextWriter(sw))
            {
                serial.Serialize(write, dx);
            }


        }



    }
}
