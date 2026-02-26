using UnityEngine;

public class FieldCell
{
    public Vector2Int Pos {  get; private set; }

    public IFieldObject Occupant { get; private set; }

    public FieldCell(int x, int y)
    {
        Pos = new Vector2Int(x, y);
        Occupant = null;
    }
}
