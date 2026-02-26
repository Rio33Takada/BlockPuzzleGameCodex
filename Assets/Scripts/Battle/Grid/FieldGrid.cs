public class FieldGrid
{
    public int Width { get; private set; }
    public int Height { get; private set; }

    private FieldCell[,] grid;

    public void CreateGrid(int width, int height)
    {
        Width = width;
        Height = height;

        grid = new FieldCell[Width, Height];

        for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                grid[x, y] = new FieldCell(x, y);
            }
        }
    }

    public FieldCell GetCell(int x, int y)
    {
        return grid[x, y];
    }
}
