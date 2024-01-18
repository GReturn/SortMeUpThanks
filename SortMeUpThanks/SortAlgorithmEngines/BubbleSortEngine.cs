using System.Diagnostics;

namespace SortMeUpThanks.SortAlgorithmEngines;

class BubbleSortEngine(int[] arr, Graphics graphics, int maxValue) : ISortEngine
{
    private readonly int[] arr = arr;
    private readonly Graphics graphics = graphics;
    private readonly int maxValue = maxValue;
    private readonly int BarWidth = GlobalVariables.BarWidth;

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

        Debug.WriteLine($"CurrentIndex: {currentIndex}, NextIndex: {nextIndex}, X1: {currentIndex * BarWidth}, X2: {nextIndex * BarWidth}");

        DrawBar(currentIndex, arr[currentIndex]);
        DrawBar(nextIndex, arr[nextIndex]);
    }
    private void DrawBar(int position, int height)
    {
        graphics.FillRectangle(new SolidBrush(Color.Black), position * BarWidth, 0, BarWidth, maxValue);
        graphics.FillRectangle(new SolidBrush(Color.White), position * BarWidth, maxValue - height, BarWidth, maxValue);
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
