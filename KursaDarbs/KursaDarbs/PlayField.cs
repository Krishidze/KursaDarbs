namespace KursaDarbs
// rinda = X*2=
// kolona = Y*2+1=
{
    public class PlayField
    {
        private CellItems?[,] grid = new CellItems?[3, 3];
        public const string GridLine = @"
7│8│9
─┼─┼─
4│5│6
─┼─┼─
1│2│3
";

        public CellItems?[,] Grid => grid;

        public Func<CellItems?[]>[] Win()
        {
            return new Func<CellItems?[]>[]
           {
             ()=> new CellItems?[]
             {
                grid[0,0],grid[0,1],grid[0,2],
             },
             ()=> new CellItems?[]
             {
                grid[1,0],grid[1,1],grid[1,2],
             },
             ()=> new CellItems?[]
             {
                grid[2,0],grid[2,1],grid[2,2],
             },
             ()=> new CellItems?[]
             {
                grid[0,0],grid[1,0],grid[2,0],
             },
              ()=> new CellItems?[]
             {
                grid[0,1],grid[1,1],grid[2,1],
             },
               ()=> new CellItems?[]
             {
                grid[0,2],grid[1,2],grid[2,2],
             },
                 ()=> new CellItems?[]
             {
                grid[0,0],grid[1,1],grid[2,2],
             },
                 ()=> new CellItems?[]
             {
                grid[2,0],grid[1,1],grid[0,2],
             },

           };

        }


    } 

}







