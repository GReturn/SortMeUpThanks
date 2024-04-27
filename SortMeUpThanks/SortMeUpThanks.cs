using SortMeUpThanks.SortAlgorithmEngines;
using System.ComponentModel;
using System.Reflection;

namespace SortMeUpThanks;

public partial class SortMeUpThanksForm : Form
{
    private readonly int BarWidth = GlobalVariables.BarWidth;
    private BackgroundWorker? bgWorker = null;
    private Graphics graphics;
    private int[] arr;
    private bool isPaused = false;

    public SortMeUpThanksForm()
    {
        InitializeComponent();
        if (arr == null)
        {
            c_btnPause.Enabled = false;
            c_btnStart.Enabled = false; 
        }
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
    private void btnStart_Click(object sender, EventArgs e)
    {
        if(arr == null) btnReset_Click(null, null);

        bgWorker = new BackgroundWorker
        {
            WorkerSupportsCancellation = true
        };
        bgWorker.DoWork += new DoWorkEventHandler(BgWorker_DoWork);
        bgWorker.RunWorkerAsync(argument: c_dropdownAlgorithms.SelectedItem);

        c_btnPause.Enabled = true;
        c_btnStart.Enabled = false;
    }
    private void c_btnPause_Click(object sender, EventArgs e)
    {
        if(!isPaused)
        {
            bgWorker.CancelAsync();
            isPaused = true;
        }
        else
        {
            if (bgWorker.IsBusy) return;
            var numEntries = c_panelSortScreen.Width / BarWidth;
            var maxValue = c_panelSortScreen.Height;
            isPaused = false;

            for (int i = 0; i < numEntries; i++)
            {
                int rectX = i * BarWidth;
                graphics.FillRectangle(new SolidBrush(Color.Black),
                    rectX, 0, BarWidth, maxValue);
                graphics.FillRectangle(new SolidBrush(Color.White), 
                    rectX, maxValue - arr[i], BarWidth, maxValue);
            }
            bgWorker.RunWorkerAsync(argument: c_dropdownAlgorithms.SelectedItem);
        }
    }
    
    private void btnReset_Click(object sender, EventArgs e)
    {
        graphics = c_panelSortScreen.CreateGraphics();
        var panelWidth = c_panelSortScreen.Width;
        var maxValue = c_panelSortScreen.Height;
        var numEntries = panelWidth / BarWidth;
        arr = new int[numEntries];

        graphics.FillRectangle(new SolidBrush(Color.Black),
                0, 0, panelWidth, maxValue);

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

        c_btnStart.Enabled = true;
    }

    #region Background Worker

    private void BgWorker_DoWork(object? sender, DoWorkEventArgs e)
    {
        BackgroundWorker worker = sender as BackgroundWorker;
        string nameSortEngine = (string)e.Argument;

        Type type = Type.GetType("SortMeUpThanks.SortAlgorithmEngines." + nameSortEngine);
        var ctors = type.GetConstructors();

        try
        {
            var sortEngine = (ISortEngine)ctors[0]
                .Invoke(new object[] { arr, graphics, c_panelSortScreen.Height });

            while (!sortEngine.IsSorted() && !bgWorker.CancellationPending)
            {
                sortEngine.Sort();
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    #endregion

    private void c_algorithmLabel_Click(object sender, EventArgs e)
    {

    }

}
