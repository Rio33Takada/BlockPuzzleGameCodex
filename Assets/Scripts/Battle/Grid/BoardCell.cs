using UnityEngine;

public class BoardCell
{
    public Vector2Int Pos {  get; private set; }

    public IBoardObject Occupant { get; private set; }

    public BoardCell(int x, int y)
    {
        Pos = new Vector2Int(x, y);
        Occupant = null;
    }
}
