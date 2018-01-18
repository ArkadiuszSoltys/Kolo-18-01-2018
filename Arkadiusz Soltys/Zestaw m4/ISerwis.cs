using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_m4
{
    interface ISerwis
    {
        void DodajTelewizor(string marka, int numerSeryjny, string usterka);
        void Dodajkomputer(string marka, int numerSeryjny, string usterka);
        void Polacz();
        void Podziel();
        void Napraw();
        void Napraw(int numerSeryjny);
    }
}
