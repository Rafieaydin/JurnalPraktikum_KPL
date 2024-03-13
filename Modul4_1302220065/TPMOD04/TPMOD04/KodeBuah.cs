using System;

namespace TPMOD04.kodebuah
{

    internal class KodeBuah
    {
        public enum namaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung }


        public static String GetKodeBuah(namaBuah nama) {
            String[] Kode = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };
            return Kode[(int)nama];

        }

    }
}
