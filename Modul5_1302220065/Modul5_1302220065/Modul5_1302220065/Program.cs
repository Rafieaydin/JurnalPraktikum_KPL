// See https://aka.ms/new-console-template for more information

namespace program;
using Modul5_1302220065.Penjumlahan;
using Modul5_1302220065.SimpleDataBase;

class Program {
    public static void Main(string[] args)
    {
        // ngambil dari nim 13 02 22
        // nim 1302220065
        // soal 1
        Penjumlahan<double> s1 = new Penjumlahan<double>();
        s1.JumlahTigaAngka(1.3 , 2.2 , 2.0);

        // soal 2
        SimpleDataBase<double> s2 = new SimpleDataBase<double>();
        s2.AddNewData(1.2);
        s2.AddNewData(2.2);
        s2.AddNewData(2.0);
        s2.PrintAllData();

    }


}
