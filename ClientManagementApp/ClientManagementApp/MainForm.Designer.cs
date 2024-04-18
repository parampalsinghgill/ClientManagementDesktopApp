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
        labelClientCode = new Label();
        textBoxClientCode = new TextBox();
        textBoxCompanyName = new TextBox();
        labelCompanyName = new Label();
        textBoxAddress1 = new TextBox();
        labelAddress1 = new Label();
        textBoxAddress2 = new TextBox();
        labelAddress2 = new Label();
        textBoxCity = new TextBox();
        labelCity = new Label();
        textBoxProvince = new TextBox();
        labelProvince = new Label();
        textBoxPostalCode = new TextBox();
        labelPostalCode = new Label();
        textBoxYtdSales = new TextBox();
        labelYtdSales = new Label();
        checkBoxCreditHold = new CheckBox();
        labelNotes = new Label();
        richTextBoxNotes = new RichTextBox();
        buttonSave = new Button();
        labelClientLegend = new Label();
        labelClientData = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewClients
        // 
        dataGridViewClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewClients.Location = new Point(12, 435);
        dataGridViewClients.Name = "dataGridViewClients";
        dataGridViewClients.Size = new Size(982, 237);
        dataGridViewClients.TabIndex = 0;
        dataGridViewClients.ColumnWidthChanged += dataGridViewClients_ColumnWidthChanged;
        dataGridViewClients.SelectionChanged += dataGridViewClients_SelectionChanged;
        // 
        // labelClientCode
        // 
        labelClientCode.AutoSize = true;
        labelClientCode.Location = new Point(17, 18);
        labelClientCode.Name = "labelClientCode";
        labelClientCode.Size = new Size(72, 15);
        labelClientCode.TabIndex = 1;
        labelClientCode.Text = "Client Code:";
        // 
        // textBoxClientCode
        // 
        textBoxClientCode.Location = new Point(148, 15);
        textBoxClientCode.Name = "textBoxClientCode";
        textBoxClientCode.Size = new Size(141, 23);
        textBoxClientCode.TabIndex = 2;
        // 
        // textBoxCompanyName
        // 
        textBoxCompanyName.Location = new Point(148, 53);
        textBoxCompanyName.Name = "textBoxCompanyName";
        textBoxCompanyName.Size = new Size(240, 23);
        textBoxCompanyName.TabIndex = 4;
        // 
        // labelCompanyName
        // 
        labelCompanyName.AutoSize = true;
        labelCompanyName.Location = new Point(17, 56);
        labelCompanyName.Name = "labelCompanyName";
        labelCompanyName.Size = new Size(97, 15);
        labelCompanyName.TabIndex = 3;
        labelCompanyName.Text = "Company Name:";
        // 
        // textBoxAddress1
        // 
        textBoxAddress1.Location = new Point(148, 91);
        textBoxAddress1.Name = "textBoxAddress1";
        textBoxAddress1.Size = new Size(240, 23);
        textBoxAddress1.TabIndex = 6;
        // 
        // labelAddress1
        // 
        labelAddress1.AutoSize = true;
        labelAddress1.Location = new Point(17, 94);
        labelAddress1.Name = "labelAddress1";
        labelAddress1.Size = new Size(61, 15);
        labelAddress1.TabIndex = 5;
        labelAddress1.Text = "Address 1:";
        // 
        // textBoxAddress2
        // 
        textBoxAddress2.Location = new Point(148, 129);
        textBoxAddress2.Name = "textBoxAddress2";
        textBoxAddress2.Size = new Size(240, 23);
        textBoxAddress2.TabIndex = 8;
        // 
        // labelAddress2
        // 
        labelAddress2.AutoSize = true;
        labelAddress2.Location = new Point(17, 132);
        labelAddress2.Name = "labelAddress2";
        labelAddress2.Size = new Size(61, 15);
        labelAddress2.TabIndex = 7;
        labelAddress2.Text = "Address 2:";
        // 
        // textBoxCity
        // 
        textBoxCity.Location = new Point(148, 167);
        textBoxCity.Name = "textBoxCity";
        textBoxCity.Size = new Size(141, 23);
        textBoxCity.TabIndex = 10;
        // 
        // labelCity
        // 
        labelCity.AutoSize = true;
        labelCity.Location = new Point(17, 170);
        labelCity.Name = "labelCity";
        labelCity.Size = new Size(31, 15);
        labelCity.TabIndex = 9;
        labelCity.Text = "City:";
        // 
        // textBoxProvince
        // 
        textBoxProvince.Location = new Point(148, 205);
        textBoxProvince.Name = "textBoxProvince";
        textBoxProvince.Size = new Size(141, 23);
        textBoxProvince.TabIndex = 12;
        // 
        // labelProvince
        // 
        labelProvince.AutoSize = true;
        labelProvince.Location = new Point(17, 208);
        labelProvince.Name = "labelProvince";
        labelProvince.Size = new Size(56, 15);
        labelProvince.TabIndex = 11;
        labelProvince.Text = "Province:";
        // 
        // textBoxPostalCode
        // 
        textBoxPostalCode.Location = new Point(148, 243);
        textBoxPostalCode.Name = "textBoxPostalCode";
        textBoxPostalCode.Size = new Size(141, 23);
        textBoxPostalCode.TabIndex = 14;
        // 
        // labelPostalCode
        // 
        labelPostalCode.AutoSize = true;
        labelPostalCode.Location = new Point(17, 246);
        labelPostalCode.Name = "labelPostalCode";
        labelPostalCode.Size = new Size(73, 15);
        labelPostalCode.TabIndex = 13;
        labelPostalCode.Text = "Postal Code:";
        // 
        // textBoxYtdSales
        // 
        textBoxYtdSales.Location = new Point(148, 281);
        textBoxYtdSales.Name = "textBoxYtdSales";
        textBoxYtdSales.Size = new Size(141, 23);
        textBoxYtdSales.TabIndex = 16;
        // 
        // labelYtdSales
        // 
        labelYtdSales.AutoSize = true;
        labelYtdSales.Location = new Point(17, 284);
        labelYtdSales.Name = "labelYtdSales";
        labelYtdSales.Size = new Size(60, 15);
        labelYtdSales.TabIndex = 15;
        labelYtdSales.Text = "YTD Sales:";
        // 
        // checkBoxCreditHold
        // 
        checkBoxCreditHold.AutoSize = true;
        checkBoxCreditHold.Location = new Point(148, 392);
        checkBoxCreditHold.Name = "checkBoxCreditHold";
        checkBoxCreditHold.Size = new Size(87, 19);
        checkBoxCreditHold.TabIndex = 17;
        checkBoxCreditHold.Text = "Credit Hold";
        checkBoxCreditHold.UseVisualStyleBackColor = true;
        // 
        // labelNotes
        // 
        labelNotes.AutoSize = true;
        labelNotes.Location = new Point(17, 322);
        labelNotes.Name = "labelNotes";
        labelNotes.Size = new Size(41, 15);
        labelNotes.TabIndex = 18;
        labelNotes.Text = "Notes:";
        // 
        // richTextBoxNotes
        // 
        richTextBoxNotes.Location = new Point(148, 319);
        richTextBoxNotes.Name = "richTextBoxNotes";
        richTextBoxNotes.Size = new Size(240, 54);
        richTextBoxNotes.TabIndex = 20;
        richTextBoxNotes.Text = "";
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(313, 388);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(75, 23);
        buttonSave.TabIndex = 21;
        buttonSave.Text = "Save";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += buttonSave_Click;
        // 
        // labelClientLegend
        // 
        labelClientLegend.AutoSize = true;
        labelClientLegend.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelClientLegend.Location = new Point(529, 18);
        labelClientLegend.Name = "labelClientLegend";
        labelClientLegend.Size = new Size(174, 300);
        labelClientLegend.TabIndex = 22;
        labelClientLegend.Text = "Client Code :\r\nCompany Name :\r\nAddress 1 :\r\nAddress 2 :\r\nCity :\r\nProvince :\r\nPostal Code :\r\nYTD Sales :\r\nCredit Hold :\r\nNotes : ";
        // 
        // labelClientData
        // 
        labelClientData.AutoSize = true;
        labelClientData.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelClientData.Location = new Point(720, 18);
        labelClientData.Name = "labelClientData";
        labelClientData.Size = new Size(66, 300);
        labelClientData.TabIndex = 23;
        labelClientData.Text = "one\r\ntwo\r\nthree\r\nfour\r\nfive\r\nsix\r\nseven\r\neight\r\nnine\r\nten";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1006, 684);
        Controls.Add(labelClientData);
        Controls.Add(labelClientLegend);
        Controls.Add(buttonSave);
        Controls.Add(richTextBoxNotes);
        Controls.Add(labelNotes);
        Controls.Add(checkBoxCreditHold);
        Controls.Add(textBoxYtdSales);
        Controls.Add(labelYtdSales);
        Controls.Add(textBoxPostalCode);
        Controls.Add(labelPostalCode);
        Controls.Add(textBoxProvince);
        Controls.Add(labelProvince);
        Controls.Add(textBoxCity);
        Controls.Add(labelCity);
        Controls.Add(textBoxAddress2);
        Controls.Add(labelAddress2);
        Controls.Add(textBoxAddress1);
        Controls.Add(labelAddress1);
        Controls.Add(textBoxCompanyName);
        Controls.Add(labelCompanyName);
        Controls.Add(textBoxClientCode);
        Controls.Add(labelClientCode);
        Controls.Add(dataGridViewClients);
        MinimumSize = new Size(600, 400);
        Name = "MainForm";
        Text = "Client Management Application";
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
        ResumeLayout(false);
        PerformLayout();
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
    private Button buttonSave;
    private Label labelClientLegend;
    private Label labelClientData;
}
