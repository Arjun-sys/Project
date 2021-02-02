using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance13.Models
{
    public class PersonMemory
    {

        private static List<PersonalDetail> detailList = new List<PersonalDetail>();


        public static List<PersonalDetail> GetPersons()
        {
            if (detailList.Count == 0)
            {
                PersonalDetail arjun = new PersonalDetail();
                arjun.PersonalDetailId = 1;
                arjun.FirstName = "arjun Krishna";
                arjun.Address = "Kathmandu";
                arjun.Age = 27;
                arjun.Occupation = "Doctor";
                //arjun.ImageLocation= "~/ images / arjun1.jpg";

                detailList.Add(arjun);



                PersonalDetail anil = new PersonalDetail();
                anil.PersonalDetailId = 2;
                anil.FirstName = "anil stha";
                anil.Address = "Dudhpati, Bhaktapur";
                anil.Age = 24;
                anil.Occupation = "Farmer";
                //anil.ImageLocation = "~/ images / dad.jpg";
                detailList.Add(anil);


                PersonalDetail ashok = new PersonalDetail();
                ashok.PersonalDetailId = 3;
                ashok.FirstName = "ashok Dahal";
                ashok.Address = "Dudhpati, Bhaktapur";
                ashok.Age = 24;
                ashok.Occupation = "Farmer";
                //ashok.ImageLocation = "~/ images / dai1.jpg";
                detailList.Add(ashok);

                PersonalDetail laxmi = new PersonalDetail();
                laxmi.PersonalDetailId = 4;
                laxmi.FirstName = "laxmi Shrestha";
                laxmi.Address = "Dudhpati, Bhaktapur";
                laxmi.Age = 24;
                laxmi.Occupation = "Student";
                //laxmi.ImageLocation = "~/ images / m1.jpg";
                detailList.Add(laxmi);

                PersonalDetail ambika = new PersonalDetail();
                ambika.PersonalDetailId = 5;
                ambika.FirstName = "ambika Dhami";
                ambika.Address = "Gothatar, Kathmandu";
                ambika.Age = 56;
                ambika.Occupation = "Student";
                //ambika.ImageLocation = "~/ images / di1.jpg";
                detailList.Add(ambika);

                PersonalDetail merika = new PersonalDetail();
                merika.PersonalDetailId = 6;
                merika.FirstName = "merika Shrestha";
                merika.Address = "Gothatar, Kathmandu";
                merika.Age = 56;
                merika.Occupation = "Student";
               // merika.ImageLocation = "~/ images / di5.jpg";
                detailList.Add(merika);
              
            }
            return detailList;
        }
        public static string GetDateInFormat(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd");
            //return dt.ToString();
        }


    }
}
