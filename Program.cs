using TicTacToe;
var board = new Board();

GameLoop:
board.DrawBoard();
board.ReadKey();
board.DrawBoard();
var winner = board.HasWinner();
if(winner != null) {
    Console.Clear();
    board.DrawBoard();
    Console.WriteLine($"Player {winner} has won!");
} else {
    Console.Clear();
    goto GameLoop;
}