
namespace TicTacToe;

public enum Mark
{
    _,
    X,
    O
};

public class Board
{
    public Board()
    {


    }

    public Mark TopLeft { get; set; } = Mark._;
    public Mark Top { get; set; } = Mark._;
    public Mark TopRight { get; set; } = Mark._;
    public Mark CenterLeft { get; set; } = Mark._;
    public Mark Center { get; set; } = Mark._;
    public Mark CenterRight { get; set; } = Mark._;
    public Mark BottomLeft { get; set; } = Mark._;
    public Mark Bottom { get; set; } = Mark._;
    public Mark BottomRight { get; set; } = Mark._;

    public bool IsPlayerOne { get; set; }

    public Mark? HasWinner()
    {
        if (new[] { TopLeft, Top, TopRight }.All(x => x == Mark.X) ||
           new[] { TopLeft, Top, TopRight }.All(x => x == Mark.O))
        {
            return TopLeft;
        }
        if (new[] { CenterLeft, Center, CenterRight }.All(x => x == Mark.X) ||
           new[] { CenterLeft, Center, CenterRight }.All(x => x == Mark.O))
        {
            return CenterLeft;
        }
        if (new[] { BottomLeft, Bottom, BottomRight }.All(x => x == Mark.X) ||
           new[] { BottomLeft, Bottom, BottomRight }.All(x => x == Mark.O))
        {
            return BottomLeft;
        }
        if (new[] { TopLeft, Center, BottomRight }.All(x => x == Mark.X) ||
          new[] { TopLeft, Center, BottomRight }.All(x => x == Mark.O))
        {
            return TopLeft;
        }
        if (new[] { TopRight, Center, BottomLeft }.All(x => x == Mark.X) ||
           new[] { TopRight, Center, BottomLeft }.All(x => x == Mark.O))
        {
            return TopRight;
        }
        if (new[] { TopLeft, CenterLeft, BottomLeft }.All(x => x == Mark.X) ||
       new[] { TopLeft, CenterLeft, BottomLeft }.All(x => x == Mark.O))
        {
            return TopLeft;
        }
        if (new[] { Top, Center, Bottom }.All(x => x == Mark.X) ||
new[] { Top, Center, Bottom }.All(x => x == Mark.O))
        {
            return Top;
        }
        if (new[] { TopRight, CenterRight, BottomRight }.All(x => x == Mark.X) ||
new[] { TopRight, CenterRight, BottomRight }.All(x => x == Mark.O))
        {
            return TopRight;
        }
        return null;
    }

    public void DrawBoard() {
        var boardDiagram = @$"  ABC{Environment.NewLine}1 {TopLeft}{Top}{TopRight}{Environment.NewLine}2 {CenterLeft}{Center}{CenterRight}{Environment.NewLine}3 {BottomLeft}{Bottom}{BottomRight}{Environment.NewLine}";
        Console.Write(boardDiagram);
    }

    public void ReadKey() {
        var input = Console.ReadLine();
        var mark = IsPlayerOne ? Mark.X : Mark.O;
        switch(input) 
        {
            case "A1":
                TopLeft = mark;
                break;
            case "B1":
                Top = mark;
                break;
            case "C1":
                TopRight = mark;
                break;   
            case "A2":
                CenterLeft = mark;
                break;
            case "B2":
                Center = mark;
                break;
            case "C2":
                CenterRight = mark;
                break;   
            case "A3":
                BottomLeft = mark;
                break;
            case "B3":
                Bottom = mark;
                break;
            case "C3":
                BottomRight = mark;
                break;                                                
        }
        IsPlayerOne = !IsPlayerOne;
    }
};