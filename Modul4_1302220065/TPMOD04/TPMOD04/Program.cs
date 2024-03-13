// See https://aka.ms/new-console-template for more information

using TPMOD04.kodebuah;
using TPMOD04.game;
namespace Program;

class Program {
    
    public static void Main(String[] args)
    {
        Console.WriteLine("Soal no 1 :");
      Console.WriteLine("Nama \t Kode");
      Console.WriteLine(KodeBuah.namaBuah.Apel +"\t"+ KodeBuah.GetKodeBuah(KodeBuah.namaBuah.Apel));
      Console.WriteLine(KodeBuah.namaBuah.Aprikot + "\t" + KodeBuah.GetKodeBuah(KodeBuah.namaBuah.Aprikot));
      Console.WriteLine(KodeBuah.namaBuah.Alpukat + "\t" + KodeBuah.GetKodeBuah(KodeBuah.namaBuah.Alpukat));
      Console.WriteLine(KodeBuah.namaBuah.Pisang + "\t" + KodeBuah.GetKodeBuah(KodeBuah.namaBuah.Pisang));
      Console.WriteLine(KodeBuah.namaBuah.Paprika + "\t" + KodeBuah.GetKodeBuah(KodeBuah.namaBuah.Paprika));
      Console.WriteLine(KodeBuah.namaBuah.Blackberry + "\t" + KodeBuah.GetKodeBuah(KodeBuah.namaBuah.Blackberry)); 
      Console.WriteLine(KodeBuah.namaBuah.Ceri + "\t" + KodeBuah.GetKodeBuah(KodeBuah.namaBuah.Ceri));
      Console.WriteLine(KodeBuah.namaBuah.Kelapa + "\t" + KodeBuah.GetKodeBuah(KodeBuah.namaBuah.Kelapa));
      Console.WriteLine(KodeBuah.namaBuah.Jagung + "\t" + KodeBuah.GetKodeBuah(KodeBuah.namaBuah.Jagung));

      Console.WriteLine("Soal no 2 : ");
      PosisiKarakterGame.run();
    }
}
