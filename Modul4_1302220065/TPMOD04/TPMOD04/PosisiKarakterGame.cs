using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD04.game
{
    internal class PosisiKarakterGame
    {
        public enum StateDo { Jongkok, Berdiri, Terungkap, Terbang, quit };
        public enum StateKeys { TombolW, TombolS }

        public static void run() {
            StateDo defaultDo = StateDo.Berdiri;
            while (defaultDo != StateDo.quit) {
                Console.WriteLine("Masukan Command :");
                String input = Console.ReadLine();
                switch (input)
                {
                    case "TombolS":
                        Console.WriteLine("tombol arah bawah ditekan");
                        break;
                    case "TombolW":
                        Console.WriteLine("tombola rah atas ditekan");
                        break;
                    case "Quit":
                        defaultDo = StateDo.quit;
                        break;

                }
            }
        }
    }
}
