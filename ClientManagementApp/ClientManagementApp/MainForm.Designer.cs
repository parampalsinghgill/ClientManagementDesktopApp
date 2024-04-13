namespace ClientManagementApp;

partial class MainForm
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
        dataGridViewClients = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewClients
        // 
        dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewClients.Location = new Point(12, 163);
        dataGridViewClients.Name = "dataGridViewClients";
        dataGridViewClients.Size = new Size(1100, 275);
        dataGridViewClients.TabIndex = 0;
        dataGridViewClients.ColumnWidthChanged += dataGridViewClients_ColumnWidthChanged;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1124, 450);
        Controls.Add(dataGridViewClients);
        MinimumSize = new Size(600, 400);
        Name = "MainForm";
        Text = "Client Management Application";
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridViewClients;
}
