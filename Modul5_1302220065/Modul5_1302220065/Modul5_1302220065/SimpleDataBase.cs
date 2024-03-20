using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_1302220065.SimpleDataBase
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase() {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }
        public void AddNewData(T input) {
            storedData.Add(input);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData() {
            for (int i = 0; i < this.storedData.Count(); i++)
            {
                Console.WriteLine("Data " + (i + 1) + " Berisi data " + this.storedData[i] + " dan tanggal" + this.inputDates[i]);
            }
        }



    }
}
