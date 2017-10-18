using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class BetegAdataiViewModel
    {
        public Beteg Beteg { get; set; }
                
        public bool IsNew { get; set; }

        Beteg BetegA;
        public BetegAdataiViewModel(Beteg Beteg)
        {
            this.Beteg = Beteg;
            if (!IsNew) Save();
        }

        public bool BetegEll()
        {
            return !string.IsNullOrEmpty(Beteg.Nev) && Beteg.TajSzam.ToString().Length == 9;
        }

        public void Save()
        {
            if (!IsNew)
            BetegA = new Beteg { Nev = Beteg.Nev, SzulHely = Beteg.SzulHely, SzulDatum = Beteg.SzulDatum, TajSzam = Beteg.TajSzam };
        }

        public void OriginalValue()
        {
            Beteg.Nev = BetegA.Nev;
            Beteg.SzulHely = BetegA.SzulHely;
            Beteg.SzulDatum = BetegA.SzulDatum;
            Beteg.TajSzam = BetegA.TajSzam;
        }

    }
}
