namespace SortMeUpThanks.SortAlgorithmEngines;

class BubbleSortEngine : ISortEngine
{
    private bool _sorted = false;
    private int[] arr;
    private Graphics graphics;
    private int maxValue;
    private int BarWidth = GlobalVariables.BarWidth;
    Brush brushWhite = new SolidBrush(Color.White);
    Brush brushBlack = new SolidBrush(Color.Black);

    public void Sort(int[] arr, Graphics graphics, int maxValue)
    {
        this.arr = arr;
        this.graphics = graphics;
        this.maxValue = maxValue;

        while(!_sorted)
        { 
            for(int i = 0; i < arr.Length - 1; i++) 
            {
                if (arr[i] > arr[i + 1])
                {
                    Swap(i, i + 1);
                }
            }
            _sorted = IsSorted();
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

    private bool IsSorted()
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1]) 
                return false;
        }
        return true;
    }
}
