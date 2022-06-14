using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursaDarbs
{
    public class GameState:PlayField
    {
        public CellItems ActivePlayer { get; set; } = CellItems.X;
        public CellItems LastActivePlayer  => ActivePlayer == CellItems.X ? CellItems.O : CellItems.X;
        // Accesability type name properties=default value
        public GameCheck gameCheck { get; set; } = GameCheck.Ongoing; 
         
    }
}
