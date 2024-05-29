using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole
{
    public class Person
    {
        public string FirstNameInput;
        public string LastNameInput;
        public string rolleInput;
        public string birthInput;
        public int AgeCalc;
        public List<person> personlist = new List<person>();
        public DateTime Age;

        public struct person
        {
            public string FirstName;
            public string LastName;
            public string birth;
            public string rolle;
            public int år;
        }
        public void PersonOpret()
        {
            Console.WriteLine("First Name: ");
            FirstNameInput = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            LastNameInput = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nBirth(DDMMYYYY):  ");
                    birthInput = Console.ReadLine();

                    if (birthInput.Length != 8)
                    {
                        throw new FormatException();
                    }
                    string[] format = {"ddMMyyyy"};
                    if (DateTime.TryParseExact(birthInput,format, null, System.Globalization.DateTimeStyles.None, out Age))
                    {
                        TimeSpan alder = DateTime.Now - Age;
                        AgeCalc = alder.Days / 365;
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt dato format");
                        throw new FormatException();
                    }
                    
                    Console.WriteLine(Age);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Du har skrevet forkert prøv igen");
                }
            }
        }
        public virtual void VisInfo(List<person> personlist)
        {

        }
    }
    //public int PersonID { get; set; }
    //public string FirstName { get; set; }
    //public string LastName { get; set; }
    //public string DOB { get; set; }
    //public string Title { get; set; }
    //public string Description { get; set; }
    //public string Tel { get; set; }
    //public string Address { get; set; }
    //public string Email { get; set; }


}

