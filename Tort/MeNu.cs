using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tort
{
    internal class MeNu
    {
        
        public static int show(int minstrelka, int maxstrelka)
        {
            int pos = 2;
            ConsoleKeyInfo key;
            do {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != minstrelka)
                    pos--;
                else if (key.Key == ConsoleKey.DownArrow && pos != maxstrelka)
                    pos++;
            } while (!(key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.Escape));
            if (key.Key == ConsoleKey.Enter){
                return pos;
            }
            else
            {
                return 0;
            }
            
        }

    }
}
