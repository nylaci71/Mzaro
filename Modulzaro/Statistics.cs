using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLinq;

namespace Modulzaro
{
    public static class Statistics
    {

        public static int BpBetegek(IEnumerable<Beteg> betegek)
        {
            return betegek.Count(x => x.SzulHely.Contains("Budapest"));
        }

        public static string LegnagyobbTajNev(IEnumerable<Beteg> betegek)
        {
            return betegek.MaxBy(x => x.TajSzam).Nev;
        }



    }
}
