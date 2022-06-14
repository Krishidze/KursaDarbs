using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursaDarbs
{
    public interface ILogic
    {
        Coordinates? ProcessKey(ConsoleKeyInfo consoleKeyInfo);
        bool IsGameOver();
        string PlayerSwitch();
    }
}
