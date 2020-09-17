using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class CKunde :CPerson
    {
        private int Kunden_ID;
        public CKunde()
        {
            Name = "Kakao";
            Vorname = "Kakadu";
            Kunden_ID = 12;
        }
        public CKunde(string name, string vorname, int kID)
        {
            Name = name;
            Vorname = vorname;
            Kunden_ID = kID;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Vorname + " " + this.Kunden_ID;
        }
    }
}
