using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_m4
{
    class Komputer : Elektronika
    
        {

        public Komputer(string marka, int numerSeryjny, string usterka)
            : base(marka, numerSeryjny, usterka)
        { 
        }


        public override string ToString()
        {
            return base.ToString() + "Komputer";

        }
    
    }
}
