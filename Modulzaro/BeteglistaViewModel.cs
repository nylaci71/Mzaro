using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Modulzaro
{

    class BetegListaViewModel : BaseModel
    {
        public ObservableCollection<Beteg> BetegLista { get; set; }
        public Beteg ValasztottBeteg { get; set; }


        public BetegListaViewModel()
        {
            BetegLista = new ObservableCollection<Beteg>
            {
                new Beteg{Nev="Kiss János", SzulHely="Budapest", SzulDatum= new DateTime(1980, 1, 18), TajSzam=123456789},
                new Beteg{Nev="Kiss György",SzulHely="Budapest", SzulDatum= new DateTime(2005, 11, 12), TajSzam=321321321},
                new Beteg{Nev="Kovács Pál",SzulHely="Szeged", SzulDatum= new DateTime(2005, 11, 12), TajSzam=545454544},
                new Beteg{Nev="Szűcs Judit",SzulHely="Szeged", SzulDatum= new DateTime(2008, 07, 11), TajSzam=444445555},
                new Beteg{Nev="Szűcs Mária",SzulHely="Sopron", SzulDatum= new DateTime(1965, 08, 05), TajSzam=987987987}
            };

        }
    }
}


