using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_m4
{
    class Serwis : ISerwis
    {

        private List<Elektronika> doNaprawy = new List<Elektronika>();

        private List<Komputer> komputery = new List<Komputer>();


        public void DodajTelewizor(string marka, int numerSeryjny, string usterka)
        {
            doNaprawy.Add(new Telewizor(marka, numerSeryjny, usterka));
        }

        public void Dodajkomputer(string marka, int numerSeryjny, string usterka)
        {
            komputery.Add(new Komputer(marka, numerSeryjny, usterka));
        }

      
        public void Polacz()
        {
            doNaprawy.AddRange(komputery);
        }

        public void Podziel()
        {
            
        }

        public void Napraw()
        {
            doNaprawy.Remove(doNaprawy.First());
        }

        public void Napraw(int numerSeryjny)
        {
                
        }

        
        public override string ToString()
        {
            return "Telewizor.marka: {0} , numerSeryjny: {1}, usterka: {3}, Komputer.marka: {4}, numerSeryjny: {5}, usterka: {6}";
         }

    }
}
