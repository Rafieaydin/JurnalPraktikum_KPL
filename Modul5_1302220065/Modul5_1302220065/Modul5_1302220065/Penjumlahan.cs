using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_1302220065.Penjumlahan
{
    internal class Penjumlahan<IN>
    {

        public void JumlahTigaAngka(IN a,IN b, IN c) {
            dynamic a1 = a; // convert ke dynamic
            dynamic b1 = b;
            dynamic c1 = c;
            Console.WriteLine(a1 + b1 + c1);

            
        }
    }
}
