// Tic Tac Toe by K and M


// Grids no 9 laukumiem - vajag uzzimet  X
// X│X│X   │ │ 
// ─┼─┼─  ─┼─┼─
// X│X│X   │ │ 
// ─┼─┼─  ─┼─┼─
// X│X│X   │ │ 
// Grids ir piesaistits pie 2d masiva X
// grid koordinates usable - 1,0 1,2 1,4
// grid koordinates usable - 3,0 3,2 3,4
// grid koordinates usable - 5,0 5,2 5,4
// lai vieglak izmantos custom data dype = enum X
// enum vajadzigs lai noteiktu X, O un NULL, atvieglos dzivi pie parbaudem X
// speles lauks bus klase X
// no speles lauka klases parbaudes tiks veiktas, vai ir ielikts, vai spele beigusies un ko darit talak X
// need win positions X
// need to see if game running  X
// need to see active player X
// need both inputs
// 

using KursaDarbs;
Console.WriteLine($"{PlayField.GridLine}");
Console.WriteLine("Enter where you want to put YOUR PIECE with 1-9 keys, fist player uses X, second O");
GameTime gameTime = new GameTime(new Logic(new GameState()));
gameTime.GameLoop();



return 0;





//Console.WriteLine($"{PlayerInput.Key}");