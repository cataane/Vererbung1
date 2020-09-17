using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class CPerson
    {
        protected string Name;
        protected string Vorname;
        public CPerson()
        {
            Name = "Cristea";
            Vorname = "Nasser";
        }
        public CPerson(string n, string v)
        {
            Name = n;
            Vorname = v;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Vorname;
        }
    }
}
