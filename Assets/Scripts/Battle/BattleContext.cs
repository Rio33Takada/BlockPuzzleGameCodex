public class BattleContext
{
    private readonly FieldGrid fieldGrid;
    private readonly BoardGrid boardGrid;

    public BattleContext(FieldGrid fieldGrid, BoardGrid boardGrid)
    {
        this.fieldGrid = fieldGrid;
        this.boardGrid = boardGrid;
    }

    public FieldGrid GetFieldGrid()
    {
        return fieldGrid;
    }

    public BoardGrid BoardGrid()
    {
        return boardGrid;
    }
}
