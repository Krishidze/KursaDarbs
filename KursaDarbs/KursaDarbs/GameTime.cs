using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursaDarbs
{
    public class GameTime
    {
        ILogic _logic;

        public GameTime(ILogic logic)
        {
            
            _logic = logic;
        }
        public void GameLoop()
        {
            ConsoleKeyInfo PlayerInput;

            do
            {
                PlayerInput = Console.ReadKey(true);
                //var KeyInput = () => Console.ReadKey(true);
                //int a = 4;
                //Console.WriteLine(a);
                //var abc = () => Console.WriteLine(a);
                //a = 5;
                //abc();

                Coordinates? activeInput = _logic.ProcessKey(PlayerInput);
                if (activeInput != null)
                {
                    Console.SetCursorPosition(activeInput.X, activeInput.Y);
                    Console.Write(_logic.PlayerSwitch());
                }
                Console.SetCursorPosition(0, 10);
                //Console.ReadKey(true);
            } while (!_logic.IsGameOver());
        }
    }
}

//do
//{
//    //code block


//} while (condition);





