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
        buttonEdit = new Button();
        buttonDelete = new Button();
        buttonNew = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewClients
        // 
        dataGridViewClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewClients.Location = new Point(12, 12);
        dataGridViewClients.Name = "dataGridViewClients";
        dataGridViewClients.Size = new Size(1468, 397);
        dataGridViewClients.TabIndex = 0;
        dataGridViewClients.ColumnWidthChanged += dataGridViewClients_ColumnWidthChanged;
        // 
        // buttonEdit
        // 
        buttonEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonEdit.Location = new Point(1388, 426);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(92, 33);
        buttonEdit.TabIndex = 3;
        buttonEdit.Text = "&Edit";
        buttonEdit.UseVisualStyleBackColor = true;
        buttonEdit.Click += buttonEdit_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonDelete.ForeColor = Color.FromArgb(192, 0, 0);
        buttonDelete.Location = new Point(1265, 426);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(92, 33);
        buttonDelete.TabIndex = 2;
        buttonDelete.Text = "&Delete";
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // buttonNew
        // 
        buttonNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        buttonNew.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonNew.Location = new Point(12, 426);
        buttonNew.Name = "buttonNew";
        buttonNew.Size = new Size(92, 33);
        buttonNew.TabIndex = 1;
        buttonNew.Text = "&New";
        buttonNew.UseVisualStyleBackColor = true;
        buttonNew.Click += buttonNew_Click;
        // 
        // MainForm
        // 
        AcceptButton = buttonEdit;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1492, 466);
        Controls.Add(buttonNew);
        Controls.Add(buttonDelete);
        Controls.Add(buttonEdit);
        Controls.Add(dataGridViewClients);
        KeyPreview = true;
        MinimumSize = new Size(600, 400);
        Name = "MainForm";
        Text = "Client Management Application";
        Load += MainForm_Load;
        KeyDown += MainForm_KeyDown;
        ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridViewClients;
    private Label labelClientCode;
    private TextBox textBoxClientCode;
    private TextBox textBoxCompanyName;
    private Label labelCompanyName;
    private TextBox textBoxAddress1;
    private Label labelAddress1;
    private TextBox textBoxAddress2;
    private Label labelAddress2;
    private TextBox textBoxCity;
    private Label labelCity;
    private TextBox textBoxProvince;
    private Label labelProvince;
    private TextBox textBoxPostalCode;
    private Label labelPostalCode;
    private TextBox textBoxYtdSales;
    private Label labelYtdSales;
    private CheckBox checkBoxCreditHold;
    private Label labelNotes;
    private RichTextBox richTextBoxNotes;
    private Button buttonEdit;
    private Button buttonDelete;
    private Button buttonNew;
    private Label labelClientLegend;
    private Label labelClientData;
}
