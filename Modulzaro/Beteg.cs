using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    public class Beteg : BaseModel
    {
        string _nev;
        string _szulhely;
        DateTime _szuldatum;
        int _tajszam;


        public string Nev { get { return _nev; } set { _nev = value; OnPropertyChange(); } }
        public string SzulHely { get { return _szulhely; } set { _szulhely = value; OnPropertyChange(); } }
        public DateTime SzulDatum { get { return _szuldatum; } set { _szuldatum = value; OnPropertyChange(); } }
        public int TajSzam { get { return _tajszam; } set { _tajszam = value; OnPropertyChange(); } }

    }
}
