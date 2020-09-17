using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class CMitarbeiter:CPerson
    {

        private string Abteilung;

        public CMitarbeiter()
        {
            Name = "Bau";
            Vorname = "Ben";
            Abteilung = "Politur";
        }
        public CMitarbeiter(string n, string v, string ab)
        {
            Name = n;
            Vorname = v;
            Abteilung = ab;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Vorname + " " + this.Abteilung;
        }
    }
}
