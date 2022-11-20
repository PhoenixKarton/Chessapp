namespace Chess;
public interface IPiece 
{
    /// <summary>
    /// Given a position on the board, returns a list of possible moves
    /// that can be made by this IPiece.
    /// </summary>
    public List<(int, int)> GetMoves();

    /// <summary>
    /// Given a starting position and a target position, returns true if the
    /// piece selected can perform such a move and false otherwise.
    /// </summary>
    public bool Logic((int row, int col) targetPos);

    /// <summary>
    /// The 2 character string representing this IPiece on the board
    /// </summary>
    public string Symbol { get; }

    /// <summary>
    /// The color of this IPiece
    /// </summary>
    public PieceColor Color { get; }

    public bool IsCaptured { get; set; }

    public bool HasMoved { get; }

    public bool Move((int row, int col) target);

    /// <summary>
    /// The position of this IPiece on the board.
    /// </summary>
    public (int row, int col) Position { get; }
}