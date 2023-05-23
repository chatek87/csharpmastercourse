using BattleshipFirstAttempt;

// test shortcut 
Game game = new Game();

game.Players[0].PlayerName = "Player A";
game.Players[0].Grid[0, 0].ContainsShip = true; //a1
game.Players[0].Grid[1, 0].ContainsShip = true; //a2
game.Players[0].Grid[2, 0].ContainsShip = true; //a3
game.Players[0].Grid[3, 0].ContainsShip = true; //a4
game.Players[0].Grid[4, 0].ContainsShip = true; //a5

game.Players[1].PlayerName = "Player B";
game.Players[1].Grid[0, 1].ContainsShip = true; //b1
game.Players[1].Grid[1, 1].ContainsShip = true; //b2
game.Players[1].Grid[2, 1].ContainsShip = true; //b3
game.Players[1].Grid[3, 1].ContainsShip = true; //b4
game.Players[1].Grid[4, 1].ContainsShip = true; //b5

game.RunGame();

//ConsoleUtils.DisplayWelcomeScreen();



//stuff to add to README:
/* terminology used in this application:
 * 
 * 'coordinate' 
 * - the player's intended target on the opponent's grid, submitted as string via ReadLine().
 * - format for coordinate is A1, B3, etc. 
 * - analogous to a 'move'
 * - used interchangeably with 'move' in some areas of this code
 * 
 * 'index'
 * - the validated (int, int) grid position, which can then be checked for Hit or Miss
 */