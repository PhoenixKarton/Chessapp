namespace Chess;

public class GameState
{
    
    private readonly Dictionary<string, IPiece> pieces = new ();

    public GameState()
    {
        for (int i = 1; i <= 8; i++)
        {
            pieces["p" + i] = new PawnPiece("p" + i, PieceColor.Blue, (1, i-1));
            pieces["P" + i] = new PawnPiece("P" + i, PieceColor.Green, (6, i-1));
        }
        pieces["k1"] = new KingPiece("k1", PieceColor.Blue, (0, 3));
        pieces["K1"] = new KingPiece("K1", PieceColor.Green, (7, 4));
    }

    public IPiece? GetPiece(string symbol)
    {
        if (pieces.TryGetValue(symbol, out IPiece? value))
        {
            return value;
        }
        return null;
    }
}