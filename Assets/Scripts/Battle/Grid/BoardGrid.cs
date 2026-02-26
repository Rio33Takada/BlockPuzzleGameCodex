public class BoardGrid
{
    public int Width { get; private set; }
    public int Height { get; private set; }

    private BoardCell[,] grid;

    public void CreateGrid(int width, int height)
    {
        Width = width;
        Height = height;

        grid = new BoardCell[Width, Height];

        for(int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                grid[x, y] = new BoardCell(x, y);
            }
        }
    }

    public BoardCell GetCell(int x, int y)
    {
        return grid[x, y];
    }
}
