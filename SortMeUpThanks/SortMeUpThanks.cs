namespace SortMeUpThanks;

public partial class SortMeUpThanksForm : Form
{
    private readonly int BarWidth = GlobalVariables.BarWidth;
    BackgroundWorker bgWorker = null;
    private Graphics graphics;
    private int[] arr;
    private bool isPaused = false;

    public SortMeUpThanksForm()
    {
        InitializeComponent();
        PopulateDropdownAlgorithms();
    }

    private void PopulateDropdownAlgorithms()
    {
        // WTF ??? THIS IS MASSIVE
        List<string> listOfAlgorithms = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
            .Where(x => typeof(ISortEngine).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
            .Select(x => x.Name).ToList();
        listOfAlgorithms.Sort();
        
        foreach (string algorithm in listOfAlgorithms) 
        {
            c_dropdownAlgorithms.Items.Add(algorithm);
        }
        c_dropdownAlgorithms.SelectedIndex = 0;
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

    #region Reset Button
    private void btnReset_Click(object sender, EventArgs e)
    {
        using(graphics = c_panelSortScreen.CreateGraphics())
        {
            ClearPanel(graphics);
            DrawBars(graphics);
        }
    }
    
    private void ClearPanel(Graphics graphics)
    {
        var panelWidth = c_panelSortScreen.Width;
        var maxValue = c_panelSortScreen.Height;

        graphics.FillRectangle(new SolidBrush(Color.Black),
                0, 0, panelWidth, maxValue);
    }

    private void DrawBars(Graphics graphics)
    {
        var panelWidth = c_panelSortScreen.Width;
        var maxValue = c_panelSortScreen.Height;
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
        c_btnStart.Enabled = false;
        c_btnReset.Enabled = false;

        using(graphics = c_panelSortScreen.CreateGraphics()) 
        { 
            var sortEngine = new BubbleSortEngine();
            sortEngine.Sort(arr, graphics, c_panelSortScreen.Height);
        }

        c_btnReset.Enabled = true;
        c_btnStart.Enabled = true;
    }
}
