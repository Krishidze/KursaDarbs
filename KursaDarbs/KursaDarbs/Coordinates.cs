using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursaDarbs
{
    public class Coordinates
    {
        public Coordinates(byte x, byte y)
        {
            X=x;
            Y=y;
        }
      public byte X { get; set; }
      public byte Y { get; set; }
     
    }
}





// grid koordinates usable - 1,0 1,2 1,4
// grid koordinates usable - 3,0 3,2 3,4
// grid koordinates usable - 5,0 5,2 5,4