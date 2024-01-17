namespace SortMeUpThanks;

public partial class SortMeUpThanksForm : Form
{
    private readonly int BarWidth = GlobalVariables.BarWidth;
    BackgroundWorker bgw = null;
    private Graphics graphics;
    private int[] arr;

    public SortMeUpThanksForm()
    {
        InitializeComponent();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

    #region Reset Button
    private void btnReset_Click(object sender, EventArgs e)
    {
        using(graphics = panelSortScreen.CreateGraphics())
        {
            ClearPanel(graphics);
            DrawBars(graphics);
        }
    }
    
    private void ClearPanel(Graphics graphics)
    {
        var panelWidth = panelSortScreen.Width;
        var maxValue = panelSortScreen.Height;

        graphics.FillRectangle(new SolidBrush(Color.Black),
                0, 0, panelWidth, maxValue);
    }

    private void DrawBars(Graphics graphics)
    {
        var panelWidth = panelSortScreen.Width;
        var maxValue = panelSortScreen.Height;
        var numEntries = panelWidth / BarWidth;
        arr = new int[numEntries];

        // Assign random value for each unit
        var random = new Random();
        for (int i = 0; i < numEntries; i++)
        {
            arr[i] = random.Next(0, maxValue);
        }

        // Fill each individual units of rectangle
        for (int i = 0; i < numEntries; i++)
        {
            int rectX = i * BarWidth;
            graphics.FillRectangle(new SolidBrush(Color.White),
                rectX, maxValue - arr[i], BarWidth, maxValue);
        }
    }

    #endregion

    private void btnStart_Click(object sender, EventArgs e)
    {
        btnStart.Enabled = false;
        btnReset.Enabled = false;

        using(graphics = panelSortScreen.CreateGraphics()) 
        { 
            var sortEngine = new BubbleSortEngine();
            sortEngine.Sort(arr, graphics, panelSortScreen.Height);
        }

        btnReset.Enabled = true;
        btnStart.Enabled = true;
    }
}
