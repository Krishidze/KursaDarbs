using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursaDarbs
// rinda = X*2=
// kolona = Y*2+1=
{
    public class PlayField
    {
        CellItems?[,] grid = new CellItems?[3,3];  
       public const string GridLine = @"
7│8│9
─┼─┼─
4│5│6
─┼─┼─
1│2│3
";

        public CellItems?[,] Grid => grid;                
        
    }

}







