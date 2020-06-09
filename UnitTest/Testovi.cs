using System;
using System.Collections.Generic;
using Fasada_Potvrda_O_Kupovini;
using Fasada_Potvrda_O_Kupovini.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTest
{
    [TestClass]
    public class Testovi
    {
        [TestMethod]
        public void TestKupca()
        {
            Kupac kupac = new Kupac
            {
                IdKupca = 1,
                Ime = "Ivo",
                Prezime = "Ivić",
                Adresa = "Ivana Meštrovica 26"
            };

            Assert.AreEqual(1, kupac.IdKupca);
            Assert.AreEqual("Ivo", kupac.Ime);
            Assert.AreEqual("Ivić", kupac.Prezime);
            Assert.AreEqual("Ivana Meštrovica 26", kupac.Adresa);
        }

        [TestMethod]
        public void TestProizvoda()
        {
            Proizvod proizvod1 = new Proizvod
            {
                IdProizvoda = 1,
                ImeProizvoda = "cipele",
                CijenaProizvoda = 100
            };

            Assert.AreEqual(1, proizvod1.IdProizvoda);
            Assert.AreEqual("cipele", proizvod1.ImeProizvoda);
            Assert.AreEqual(100, proizvod1.CijenaProizvoda);
        }


        [TestMethod]
        public void TestKupovine()
        {

            Kupovina kupovina = new Kupovina
            {
                IdKupca = 1,
                IdKupljenihProizvoda = new List<int>() { 1, 2, 3 },
                IdKupovine = 2
            };

            Proizvod proizvod1 = new Proizvod
            {
                IdProizvoda = 1,
                ImeProizvoda = "cipele",
                CijenaProizvoda = 100
            };

            Proizvod proizvod2 = new Proizvod
            {
                IdProizvoda = 2,
                ImeProizvoda = "badekostim",
                CijenaProizvoda = 100
            };

            Proizvod proizvod3 = new Proizvod
            {
                IdProizvoda = 3,
                ImeProizvoda = "ručnik",
                CijenaProizvoda = 100
            };

            Assert.AreEqual(2, kupovina.IdKupovine);
            Assert.AreEqual(1, kupovina.IdKupca);

            List<int> idproizvoda = new List<int>() { proizvod1.IdProizvoda, proizvod2.IdProizvoda, proizvod3.IdProizvoda };
            CollectionAssert.AreEqual(idproizvoda, kupovina.IdKupljenihProizvoda);

        }

        [TestMethod]
        public void TestDohvaćanjaImenaiPrezimenaIAdreseKupaca()
        {
            Kupac kupac = new Kupac
            {
                IdKupca = 1,
                Ime = "Ivo",
                Prezime = "Ivić",
                Adresa = "Ivana Meštrovica 26"
            };

            Kupovina kupovina = new Kupovina
            {
                IdKupca = 1,
                IdKupljenihProizvoda = new List<int>() { 1, 2, 3 },
                IdKupovine = 2
            }; 

            Proizvod proizvod1 = new Proizvod
            {
                IdProizvoda = 1,
                ImeProizvoda = "cipele",
                CijenaProizvoda = 100
            };
            Proizvod proizvod2 = new Proizvod
            {
                IdProizvoda = 2,
                ImeProizvoda = "badekostim",
                CijenaProizvoda = 100
            };
            Proizvod proizvod3 = new Proizvod
            {
                IdProizvoda = 3,
                ImeProizvoda = "ručnik",
                CijenaProizvoda = 100
            };
            List<Proizvod> proizvodi = new List<Proizvod>() { proizvod1, proizvod2, proizvod3 };


            FacadePotvrdaOKupovini potvrda = new FacadePotvrdaOKupovini(kupac, kupovina, proizvodi);

            List<string> testpodatciOkupcu = new List<string>() { "Ivo", "Ivić", "Ivana Meštrovica 26" };

            CollectionAssert.AreEqual(testpodatciOkupcu, potvrda.DohvatiPodatkeOKupcu());

        }

        [TestMethod]
        public void TestDohvaćanjaUkupneCijene()
        {
            Kupac kupac = new Kupac
            {
                IdKupca = 1,
                Ime = "Ivo",
                Prezime = "Ivić",
                Adresa = "Ivana Meštrovica 26"
            };

            Kupovina kupovina = new Kupovina
            {
                IdKupca = 1,
                IdKupljenihProizvoda = new List<int>() { 1, 2, 3 },
                IdKupovine = 2
            };

            Proizvod proizvod1 = new Proizvod
            {
                IdProizvoda = 1,
                ImeProizvoda = "cipele",
                CijenaProizvoda = 100
            };
            Proizvod proizvod2 = new Proizvod
            {
                IdProizvoda = 2,
                ImeProizvoda = "badekostim",
                CijenaProizvoda = 100
            };
            Proizvod proizvod3 = new Proizvod
            {
                IdProizvoda = 3,
                ImeProizvoda = "ručnik",
                CijenaProizvoda = 100
            };
            List<Proizvod> proizvodi = new List<Proizvod>() { proizvod1, proizvod2, proizvod3 };

            FacadePotvrdaOKupovini potvrda = new FacadePotvrdaOKupovini(kupac, kupovina, proizvodi);

            Assert.AreEqual(300, potvrda.DohvatiUkupnuCijenu());

        }

        [TestMethod]
        public void TestDohvaćanjaProizvoda()
        {
            Kupac kupac = new Kupac
            {
                IdKupca = 1,
                Ime = "Ivo",
                Prezime = "Ivić",
                Adresa = "Ivana Meštrovica 26"
            };

            Kupovina kupovina = new Kupovina
            {
                IdKupca = 1,
                IdKupljenihProizvoda = new List<int>() { 1, 2, 3 },
                IdKupovine = 2
            };

            Proizvod proizvod1 = new Proizvod
            {
                IdProizvoda = 1,
                ImeProizvoda = "cipele",
                CijenaProizvoda = 100
            };

            Proizvod proizvod2 = new Proizvod
            {
                IdProizvoda = 2,
                ImeProizvoda = "badekostim",
                CijenaProizvoda = 100
            };

            Proizvod proizvod3 = new Proizvod
            {
                IdProizvoda = 3,
                ImeProizvoda = "ručnik",
                CijenaProizvoda = 100
            };

            List<Proizvod> proizvodi = new List<Proizvod>() { proizvod1, proizvod2, proizvod3 };

            FacadePotvrdaOKupovini potvrda = new FacadePotvrdaOKupovini(kupac, kupovina, proizvodi);


            List<string> imenaProizvoda = new List<string>() { "cipele", "badekostim", "ručnik" };
            CollectionAssert.AreEqual(imenaProizvoda, potvrda.DohvatiProizvode());
        }

        [TestMethod]
        public void TestDohvaćanjaSvega()
        {
            Kupac kupac = new Kupac
            {
                IdKupca = 1,
                Ime = "Ivo",
                Prezime = "Ivić",
                Adresa = "Ivana Meštrovica 26"
            };

            Kupovina kupovina = new Kupovina
            {
                IdKupca = 1,
                IdKupljenihProizvoda = new List<int>() { 1, 2, 3 },
                IdKupovine = 2
            };

            Proizvod proizvod1 = new Proizvod
            {
                IdProizvoda = 1,
                ImeProizvoda = "cipele",
                CijenaProizvoda = 100
            };

            Proizvod proizvod2 = new Proizvod
            {
                IdProizvoda = 2,
                ImeProizvoda = "badekostim",
                CijenaProizvoda = 100
            };

            Proizvod proizvod3 = new Proizvod
            {
                IdProizvoda = 3,
                ImeProizvoda = "ručnik",
                CijenaProizvoda = 100
            };

            List<Proizvod> proizvodi = new List<Proizvod>() { proizvod1, proizvod2, proizvod3 };

            FacadePotvrdaOKupovini potvrda = new FacadePotvrdaOKupovini(kupac, kupovina, proizvodi);
            string svipodatci = potvrda.DohvatiPodatkeOKupcu().ToString() + potvrda.DohvatiProizvode().ToString() + potvrda.DohvatiUkupnuCijenu();

            Assert.AreEqual(svipodatci, potvrda.DobaviSvePodatke(2));
            Assert.AreEqual("Unjeli ste krivi ID, pokušajte ponovo", potvrda.DobaviSvePodatke(1));
        }
    }
}
