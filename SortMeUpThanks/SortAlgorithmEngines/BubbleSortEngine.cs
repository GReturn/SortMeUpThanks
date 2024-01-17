namespace SortMeUpThanks.SortAlgorithmEngines;

class BubbleSortEngine(int[] arr, Graphics graphics, int maxValue) : ISortEngine
{
    private readonly int[] arr = arr;
    private readonly Graphics graphics = graphics;
    private readonly int maxValue = maxValue;
    private readonly int BarWidth = GlobalVariables.BarWidth;
    readonly Brush brushWhite = new SolidBrush(Color.White);
    readonly Brush brushBlack = new SolidBrush(Color.Black);

    public void Sort()
    {
        for(int i = 0; i < arr.Length - 1; i++) 
        {
            if (arr[i] > arr[i + 1])
            {
                Swap(i, i + 1);
            }
        }
    }

    private void Swap(int currentIndex, int nextIndex)
    {
        (arr[nextIndex], arr[currentIndex]) = (arr[currentIndex], arr[nextIndex]);

        graphics.FillRectangle(brushBlack, currentIndex * BarWidth, 0, BarWidth, maxValue);
        graphics.FillRectangle(brushBlack, nextIndex * BarWidth, 0, BarWidth, maxValue);

        graphics.FillRectangle(brushWhite, currentIndex*BarWidth, maxValue - arr[currentIndex], BarWidth, maxValue);
        graphics.FillRectangle(brushWhite, nextIndex*BarWidth, maxValue - arr[nextIndex], BarWidth, maxValue);
    }

    public bool IsSorted()
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1]) 
                return false;
        }
        return true;
    }

    public void Resume()
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int RectX = i * BarWidth;
            graphics.FillRectangle(new SolidBrush(Color.White),
                RectX, maxValue - arr[i], BarWidth, maxValue);
        }
    }
}
