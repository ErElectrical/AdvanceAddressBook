using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;


namespace AddressBookUser
{
    public class CsvFile
    {
       public static string ExPortFilePath = @"C:\Users\as\Desktop\.net\AddressBookUser\utility\ExPortFile.csv";
       public static string ImPortFilePath = @"C:\Users\as\Desktop\.net\AddressBookUser\utility\importFile.csv";

        public static void CsvHandle()
        {
            using (var read = new StreamReader(ImPortFilePath))
            using (var csv = new CsvReader(read, System.Globalization.CultureInfo.InvariantCulture))
            {
                int i;
                Contact a = new Contact();
                var re = csv.GetRecord<Contact>().ToList();
                Console.WriteLine("read data successFully");
                foreach(Contact a in re)
                {
                    Console.WriteLine("First Name : {0} ", a.firstName);
                    Console.WriteLine("Last Name : {0} ", a.lastName);
                    Console.WriteLine("address : {0} ", a.address);
                    Console.WriteLine("Phone : {0} ", a.PhoneNunmber);
                    Console.WriteLine("ZipCode : {0} ", a.ZipCode);
                    Console.WriteLine("state : {0} ", a.state);
                    Console.WriteLine("City : {0} ", a.city);







                }

                Console.WriteLine("reading from csv file and writing to csv file");

                using (var writer = new StreamWriter(ExPortFilePath))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(re);
                }

            }


        }

    }

}
