using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class Kezelesek : BaseModel
    {
        string _beteg_neve;
        int _eletkor;
        int _tajszam;
        string _bnokod;
        int _megjegyzes;


        public string BetegNeve { get { return _beteg_neve; } set { _beteg_neve = value; OnPropertyChange(); } }
        public int Eletkor { get { return _eletkor; } set { _eletkor = value; OnPropertyChange(); } }
        public int TajSzam { get { return _tajszam; } set { _tajszam = value; OnPropertyChange(); } }
        public string BnoKod { get { return _bnokod; } set { _bnokod = value; OnPropertyChange(); } }
        public int Megjegyzes { get { return _megjegyzes; } set { _megjegyzes = value; OnPropertyChange(); } }
    }
}
