namespace SortMeUpThanks;

partial class SortMeUpThanksForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Menus = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        exitToolStripMenuItem = new ToolStripMenuItem();
        helpToolStripMenuItem = new ToolStripMenuItem();
        algorithmLabel = new Label();
        dropdownAlgorithms = new ComboBox();
        btnReset = new Button();
        btnStart = new Button();
        panelSortScreen = new Panel();
        Menus.SuspendLayout();
        SuspendLayout();
        // 
        // Menus
        // 
        Menus.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
        Menus.Location = new Point(0, 0);
        Menus.Name = "Menus";
        Menus.Size = new Size(1064, 24);
        Menus.TabIndex = 0;
        Menus.Text = "Menus";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "File";
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new Size(93, 22);
        exitToolStripMenuItem.Text = "Exit";
        exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Size = new Size(44, 20);
        helpToolStripMenuItem.Text = "Help";
        // 
        // algorithmLabel
        // 
        algorithmLabel.AutoSize = true;
        algorithmLabel.Location = new Point(12, 32);
        algorithmLabel.Name = "algorithmLabel";
        algorithmLabel.Size = new Size(61, 15);
        algorithmLabel.TabIndex = 1;
        algorithmLabel.Text = "Algorithm";
        // 
        // dropdownAlgorithms
        // 
        dropdownAlgorithms.FormattingEnabled = true;
        dropdownAlgorithms.Location = new Point(79, 27);
        dropdownAlgorithms.Name = "dropdownAlgorithms";
        dropdownAlgorithms.Size = new Size(191, 23);
        dropdownAlgorithms.TabIndex = 2;
        // 
        // btnReset
        // 
        btnReset.Location = new Point(276, 26);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(75, 23);
        btnReset.TabIndex = 3;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;
        // 
        // btnStart
        // 
        btnStart.Location = new Point(357, 26);
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(75, 23);
        btnStart.TabIndex = 4;
        btnStart.Text = "Start";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Click += btnStart_Click;
        // 
        // panelSortScreen
        // 
        panelSortScreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panelSortScreen.BackColor = SystemColors.ControlDark;
        panelSortScreen.Location = new Point(9, 87);
        panelSortScreen.Name = "panelSortScreen";
        panelSortScreen.Size = new Size(1044, 588);
        panelSortScreen.TabIndex = 5;
        // 
        // SortMeUpThanksForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1064, 681);
        Controls.Add(panelSortScreen);
        Controls.Add(btnStart);
        Controls.Add(btnReset);
        Controls.Add(dropdownAlgorithms);
        Controls.Add(algorithmLabel);
        Controls.Add(Menus);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MainMenuStrip = Menus;
        Name = "SortMeUpThanksForm";
        Text = "SMUT - SortMeUpThanks (Sorting Algorithm Visualizer)";
        Menus.ResumeLayout(false);
        Menus.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip Menus;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private Label algorithmLabel;
    private ComboBox dropdownAlgorithms;
    private Button btnReset;
    private Button btnStart;
    private Panel panelSortScreen;
}
