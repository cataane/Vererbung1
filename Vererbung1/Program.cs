using System;
using System.Collections;

namespace Vererbung
{
    static class Program
    {      
        static void Main(string[] args)
        {
            Console.WriteLine("Va salut");

            CPerson person = new CPerson(read(msg: "Geben sie den Name des Person ein:"),
                                         read(msg: "Geben sie den Vorname des Person auch:"));

            CMitarbeiter mitarbeiter = new CMitarbeiter(read(msg: "Geben sie den Name des Mitarbeiter ein:"),
                                                        read(msg: "Geben sie den Vorname des Mitarbeiter auch:"),
                                                        read(msg: "Geben sie Abteilung von Mitarbeiter"));

            CKunde kunde = new CKunde(read(msg: "Geben sie den Name des Kunde ein:"),
                                      read(msg: "Geben sie den Vorname des Kunde auch:"),
                                      Int32.Parse(read(msg: "Geben sie die Kunde ID ein")));

            ArrayList list = new ArrayList { person, mitarbeiter, kunde};
            foreach (object item in list)
            {
                Console.WriteLine(item.ToString());
            }            
        }

        private static string read(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }
    }
}
