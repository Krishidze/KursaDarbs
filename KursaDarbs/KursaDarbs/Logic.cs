using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursaDarbs
{
    public class Logic
    {
        private readonly PlayField _playField;
        public Logic(PlayField playField)
        {
            _playField = playField;
        }

        public Coordinates ProcessKey(ConsoleKeyInfo consoleKeyInfo)
        {
            if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
            {
                return AssignCoordinates(0, 2);
            }
            else if (consoleKeyInfo.Key == ConsoleKey.D2 || consoleKeyInfo.Key == ConsoleKey.NumPad2)
            {
                return AssignCoordinates(1, 2);
            }
            return null;

        }

        private Coordinates AssignCoordinates(byte x, byte y)
        {
            _playField.Grid[x, y] = CellItems.X;
            return new Coordinates((byte)(x * 2), (byte)((y * 2) + 1));
        }
    }
}
// rinda = X*2=
// kolona = Y*2+1=
// grid koordinates usable - 1,0 1,2 1,4
// grid koordinates usable - 3,0 3,2 3,4
// grid koordinates usable - 5,0 5,2 5,4