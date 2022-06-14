using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursaDarbs
{
    public class Logic:ILogic
    {
        private readonly GameState _gameState;
        public Logic(GameState gameState)
        {
            _gameState = gameState;
        }

        public Coordinates? ProcessKey(ConsoleKeyInfo consoleKeyInfo) => consoleKeyInfo.Key switch
        {
            ConsoleKey.D1 or ConsoleKey.NumPad1 => AssignCoordinates(0, 2),
            ConsoleKey.D2 or ConsoleKey.NumPad2 => AssignCoordinates(1, 2),
            ConsoleKey.D3 or ConsoleKey.NumPad3 => AssignCoordinates(2, 2),
            ConsoleKey.D4 or ConsoleKey.NumPad4 => AssignCoordinates(0, 1),
            ConsoleKey.D5 or ConsoleKey.NumPad5 => AssignCoordinates(1, 1),
            ConsoleKey.D6 or ConsoleKey.NumPad6 => AssignCoordinates(2, 1),
            ConsoleKey.D7 or ConsoleKey.NumPad7 => AssignCoordinates(0, 0),
            ConsoleKey.D8 or ConsoleKey.NumPad8 => AssignCoordinates(1, 0),
            ConsoleKey.D9 or ConsoleKey.NumPad9 => AssignCoordinates(2, 0),
            _ => null
        };

        private Coordinates AssignCoordinates(byte x, byte y)
        {
            _gameState.Grid[x, y] = _gameState.ActivePlayer;
            return new Coordinates((byte)(x * 2), (byte)((y * 2) + 1));
        }
        
        public bool IsGameOver()
        {
            return _gameState.gameCheck != GameCheck.Ongoing;
        }
        public string PlayerSwitch()
        {
            _gameState.ActivePlayer = _gameState.LastActivePlayer;
            return _gameState.LastActivePlayer.ToString();
        }
    }
}
// rinda = X*2=
// kolona = Y*2+1=
