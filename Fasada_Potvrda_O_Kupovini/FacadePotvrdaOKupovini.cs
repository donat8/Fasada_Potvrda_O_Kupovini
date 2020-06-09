using Fasada_Potvrda_O_Kupovini.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada_Potvrda_O_Kupovini
{
    public class FacadePotvrdaOKupovini
    {
        Kupac kupac;
        Kupovina kupovina;
        List<Proizvod> proizvodi;

        public FacadePotvrdaOKupovini(Kupac kupac, Kupovina kupovina, List<Proizvod> proizvodi)
        {
            this.kupac = kupac;
            this.kupovina = kupovina;
            this.proizvodi= proizvodi;
        }

        public List<string> DohvatiPodatkeOKupcu()
        {
            List<string> podatci = new List<string>
            {
                kupac.Ime,
                kupac.Prezime,
                kupac.Adresa
            };
            return podatci;
        }

        public List<string> DohvatiProizvode()
        {
            List<string> listaImenaProizvoda = new List<string>();

            foreach (var proizvod in proizvodi) {
                listaImenaProizvoda.Add(proizvod.ImeProizvoda.ToString());
            }

            return listaImenaProizvoda;
        }

        public double DohvatiUkupnuCijenu()
        {
            double ukupnaCijena = 0;
            foreach(var proizvod in proizvodi)
            {
                ukupnaCijena += proizvod.CijenaProizvoda;
            }
            return ukupnaCijena;
        }

        public string DobaviSvePodatke(int idKupovine)
        {
            if (idKupovine == kupovina.IdKupovine)
            {
                string podatci=DohvatiPodatkeOKupcu().ToString();
                string proizvodi=DohvatiProizvode().ToString();
                string ukupnaCijena=DohvatiUkupnuCijenu().ToString();
                string svipodatci = podatci + proizvodi + ukupnaCijena;
                return svipodatci;
            }
            return "Unjeli ste krivi ID, pokušajte ponovo";

        }
    }
}
