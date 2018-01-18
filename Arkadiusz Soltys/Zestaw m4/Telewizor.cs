using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_m4
{
    class Telewizor:Elektronika
    {

        public Telewizor(string marka, int numerSeryjny, string usterka)
            : base(marka, numerSeryjny, usterka)
        { 
        }


        public override string ToString()
        {
            return base.ToString() + "Telewizor";
          
        }
    }
}
