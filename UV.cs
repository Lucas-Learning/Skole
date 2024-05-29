using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole
{
    public class UV : Person
    {
        string Rolle = "Lære";
        public void TilføjUV(List<person> personlist)
        {
            
            PersonOpret();

            person p1;
            p1.FirstName = FirstNameInput;
            p1.LastName = LastNameInput;
            p1.birth = birthInput;
            p1.rolle = Rolle;
            p1.år = AgeCalc;
            personlist.Add(p1);

            Console.WriteLine($"{p1.FirstName} {p1.LastName}\nRolle: {p1.rolle}");
            
            Console.WriteLine("Du er {0} år gammel", p1.år);

        }
        public override void VisInfo(List<person> personlist)
        {  
            foreach(person p1 in personlist)
            {       
                    Console.WriteLine($"{p1.FirstName} {p1.LastName}\nRolle: {p1.rolle}\nAlder: {p1.år}");
            }
        }
    }
}
