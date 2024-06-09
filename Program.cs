using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Skole.Person;

namespace Skole
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person p = new Person();
           bool quit = false;

            while (!quit)
            {
                Console.WriteLine("Vælg en handling:");
                Console.WriteLine("1. Tilføj bruger");
                Console.WriteLine("2. Vis brugere");
                Console.WriteLine("4. Quit");

                string valg = Console.ReadLine();
                Student student = new Student();
                Admin admin = new Admin();
                UV uV = new UV();
                switch (valg)
                {

                    case "1":
                        Console.WriteLine("Tryk 1 for at opret en student\nTryk 2 for at opret en UV\nTryk 3 for at opret en Admin");
                        string valgperson = Console.ReadLine();
                        
                        if (valgperson == "1")
                        {
                            
                            student.TilføjStudent(p.personlist);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (valgperson == "2")
                        {
                            
                            uV.TilføjUV(p.personlist);
                            Console.ReadKey();
                            Console.Clear();

                        }
                        else if (valgperson == "3")
                        {
                            
                            admin.TilføjAdmin(p.personlist);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "2":
                        /*if (personlist.Count > 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Hvilken rolle vil du se:\n-Lære\n-Admin\n-Student");
                            string rolleInput = Console.ReadLine();
                            foreach (person p1 in personlist)
                            {
                                if (p1.rolle == rolleInput)
                                {
                                    Person p = new Person();
                                    Console.Clear();
                                    Console.WriteLine($"{p1.FirstName} {p1.LastName}\nRolle: {p1.rolle}\nAlder: {p.år}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("der findes ikke nogen brugere. \ntryk enter for at komme tilbage til menu");
                        }
                        Console.ReadKey();
                        Console.Clear();*/
                        student.VisInfo(p.personlist);
                        uV.VisInfo(p.personlist);
                        admin.VisInfo(p.personlist);
                        Console.ReadKey();
                        break;
                    case "4":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg. Prøv igen.");
                        break;
                }
            }
        }
    }
}

