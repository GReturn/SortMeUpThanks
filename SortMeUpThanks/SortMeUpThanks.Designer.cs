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
        c_fileToolStripMenuItem = new ToolStripMenuItem();
        c_exitToolStripMenuItem = new ToolStripMenuItem();
        c_helpToolStripMenuItem = new ToolStripMenuItem();
        c_algorithmLabel = new Label();
        c_dropdownAlgorithms = new ComboBox();
        c_btnReset = new Button();
        c_btnStart = new Button();
        c_panelSortScreen = new Panel();
        Menus.SuspendLayout();
        SuspendLayout();
        // 
        // Menus
        // 
        Menus.Items.AddRange(new ToolStripItem[] { c_fileToolStripMenuItem, c_helpToolStripMenuItem });
        Menus.Location = new Point(0, 0);
        Menus.Name = "Menus";
        Menus.Size = new Size(1064, 24);
        Menus.TabIndex = 0;
        Menus.Text = "Menus";
        // 
        // c_fileToolStripMenuItem
        // 
        c_fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { c_exitToolStripMenuItem });
        c_fileToolStripMenuItem.Name = "c_fileToolStripMenuItem";
        c_fileToolStripMenuItem.Size = new Size(37, 20);
        c_fileToolStripMenuItem.Text = "File";
        // 
        // c_exitToolStripMenuItem
        // 
        c_exitToolStripMenuItem.Name = "c_exitToolStripMenuItem";
        c_exitToolStripMenuItem.Size = new Size(180, 22);
        c_exitToolStripMenuItem.Text = "Exit";
        c_exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
        // 
        // c_helpToolStripMenuItem
        // 
        c_helpToolStripMenuItem.Name = "c_helpToolStripMenuItem";
        c_helpToolStripMenuItem.Size = new Size(44, 20);
        c_helpToolStripMenuItem.Text = "Help";
        // 
        // c_algorithmLabel
        // 
        c_algorithmLabel.AutoSize = true;
        c_algorithmLabel.Location = new Point(12, 32);
        c_algorithmLabel.Name = "c_algorithmLabel";
        c_algorithmLabel.Size = new Size(61, 15);
        c_algorithmLabel.TabIndex = 1;
        c_algorithmLabel.Text = "Algorithm";
        // 
        // c_dropdownAlgorithms
        // 
        c_dropdownAlgorithms.FormattingEnabled = true;
        c_dropdownAlgorithms.Location = new Point(79, 27);
        c_dropdownAlgorithms.Name = "c_dropdownAlgorithms";
        c_dropdownAlgorithms.Size = new Size(191, 23);
        c_dropdownAlgorithms.TabIndex = 2;
        // 
        // c_btnReset
        // 
        c_btnReset.Location = new Point(276, 26);
        c_btnReset.Name = "c_btnReset";
        c_btnReset.Size = new Size(75, 23);
        c_btnReset.TabIndex = 3;
        c_btnReset.Text = "Reset";
        c_btnReset.UseVisualStyleBackColor = true;
        c_btnReset.Click += btnReset_Click;
        // 
        // c_btnStart
        // 
        c_btnStart.Location = new Point(357, 26);
        c_btnStart.Name = "c_btnStart";
        c_btnStart.Size = new Size(75, 23);
        c_btnStart.TabIndex = 4;
        c_btnStart.Text = "Start";
        c_btnStart.UseVisualStyleBackColor = true;
        c_btnStart.Click += btnStart_Click;
        // 
        // c_panelSortScreen
        // 
        c_panelSortScreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        c_panelSortScreen.BackColor = SystemColors.ControlDark;
        c_panelSortScreen.Location = new Point(9, 87);
        c_panelSortScreen.Name = "c_panelSortScreen";
        c_panelSortScreen.Size = new Size(1044, 588);
        c_panelSortScreen.TabIndex = 5;
        // 
        // SortMeUpThanksForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1064, 681);
        Controls.Add(c_panelSortScreen);
        Controls.Add(c_btnStart);
        Controls.Add(c_btnReset);
        Controls.Add(c_dropdownAlgorithms);
        Controls.Add(c_algorithmLabel);
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
    private ToolStripMenuItem c_fileToolStripMenuItem;
    private ToolStripMenuItem c_exitToolStripMenuItem;
    private ToolStripMenuItem c_helpToolStripMenuItem;
    private Label c_algorithmLabel;
    private ComboBox c_dropdownAlgorithms;
    private Button c_btnReset;
    private Button c_btnStart;
    private Panel c_panelSortScreen;
}
