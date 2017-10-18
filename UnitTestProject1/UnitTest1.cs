using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modulzaro;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BpBetegekSzama()
        {
            var cnt = Statistics.BpBetegek(
                    new[]
                    {
                        new Beteg{Nev="Kiss János", SzulHely="Budapest", SzulDatum= new DateTime(1980, 1, 18), TajSzam=123456789},
                        new Beteg{Nev="Kiss György",SzulHely="Budapest", SzulDatum= new DateTime(2005, 11, 12), TajSzam=321321321},
                        new Beteg{Nev="Kovács Pál",SzulHely="Szeged", SzulDatum= new DateTime(2005, 11, 12), TajSzam=545454544}
                    }
                );
            Assert.AreEqual(2, cnt);
        }


        [TestMethod]
        public void MaxTajTeszt()
        {
            var nev = Statistics.LegnagyobbTajNev(
                    new[]
                    {
                        new Beteg{Nev="Kiss János", SzulHely="Budapest", SzulDatum= new DateTime(1980, 1, 18), TajSzam=123456789},
                        new Beteg{Nev="Kiss György",SzulHely="Budapest", SzulDatum= new DateTime(2005, 11, 12), TajSzam=321321321},
                        new Beteg{Nev="Kovács Pál",SzulHely="Szeged", SzulDatum= new DateTime(2005, 11, 12), TajSzam=545454544}
                    }
                );
            Assert.AreEqual("Kovács Pál", nev);
        }
    }
}
