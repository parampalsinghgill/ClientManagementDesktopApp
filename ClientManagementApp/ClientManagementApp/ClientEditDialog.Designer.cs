namespace ClientManagementApp;

partial class ClientEditDialog
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        buttonCancel = new Button();
        buttonOk = new Button();
        richTextBoxNotes = new RichTextBox();
        labelNotes = new Label();
        checkBoxCreditHold = new CheckBox();
        textBoxYtdSales = new TextBox();
        labelYtdSales = new Label();
        textBoxPostalCode = new TextBox();
        labelPostalCode = new Label();
        textBoxProvince = new TextBox();
        labelProvince = new Label();
        textBoxCity = new TextBox();
        labelCity = new Label();
        textBoxAddress2 = new TextBox();
        labelAddress2 = new Label();
        textBoxAddress1 = new TextBox();
        labelAddress1 = new Label();
        textBoxCompanyName = new TextBox();
        labelCompanyName = new Label();
        textBoxClientCode = new TextBox();
        labelClientCode = new Label();
        SuspendLayout();
        // 
        // buttonCancel
        // 
        buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonCancel.Location = new Point(337, 503);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(75, 23);
        buttonCancel.TabIndex = 20;
        buttonCancel.Text = "&Cancel";
        buttonCancel.UseVisualStyleBackColor = true;
        // 
        // buttonOk
        // 
        buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonOk.FlatStyle = FlatStyle.System;
        buttonOk.Location = new Point(240, 503);
        buttonOk.Name = "buttonOk";
        buttonOk.Size = new Size(75, 23);
        buttonOk.TabIndex = 19;
        buttonOk.Text = "&OK";
        buttonOk.UseVisualStyleBackColor = true;
        buttonOk.Click += buttonOk_Click;
        // 
        // richTextBoxNotes
        // 
        richTextBoxNotes.Location = new Point(111, 323);
        richTextBoxNotes.Name = "richTextBoxNotes";
        richTextBoxNotes.Size = new Size(301, 126);
        richTextBoxNotes.TabIndex = 17;
        richTextBoxNotes.Text = "";
        // 
        // labelNotes
        // 
        labelNotes.AutoSize = true;
        labelNotes.Location = new Point(8, 326);
        labelNotes.Name = "labelNotes";
        labelNotes.Size = new Size(41, 15);
        labelNotes.TabIndex = 16;
        labelNotes.Text = "Notes:";
        // 
        // checkBoxCreditHold
        // 
        checkBoxCreditHold.AutoSize = true;
        checkBoxCreditHold.Location = new Point(111, 464);
        checkBoxCreditHold.Name = "checkBoxCreditHold";
        checkBoxCreditHold.Size = new Size(87, 19);
        checkBoxCreditHold.TabIndex = 18;
        checkBoxCreditHold.Text = "Credit Hold";
        checkBoxCreditHold.UseVisualStyleBackColor = true;
        // 
        // textBoxYtdSales
        // 
        textBoxYtdSales.Location = new Point(111, 285);
        textBoxYtdSales.Name = "textBoxYtdSales";
        textBoxYtdSales.Size = new Size(141, 23);
        textBoxYtdSales.TabIndex = 15;
        // 
        // labelYtdSales
        // 
        labelYtdSales.AutoSize = true;
        labelYtdSales.Location = new Point(8, 288);
        labelYtdSales.Name = "labelYtdSales";
        labelYtdSales.Size = new Size(60, 15);
        labelYtdSales.TabIndex = 14;
        labelYtdSales.Text = "YTD Sales:";
        // 
        // textBoxPostalCode
        // 
        textBoxPostalCode.Location = new Point(111, 247);
        textBoxPostalCode.Name = "textBoxPostalCode";
        textBoxPostalCode.Size = new Size(141, 23);
        textBoxPostalCode.TabIndex = 13;
        // 
        // labelPostalCode
        // 
        labelPostalCode.AutoSize = true;
        labelPostalCode.Location = new Point(8, 250);
        labelPostalCode.Name = "labelPostalCode";
        labelPostalCode.Size = new Size(73, 15);
        labelPostalCode.TabIndex = 12;
        labelPostalCode.Text = "Postal Code:";
        // 
        // textBoxProvince
        // 
        textBoxProvince.Location = new Point(111, 209);
        textBoxProvince.Name = "textBoxProvince";
        textBoxProvince.Size = new Size(141, 23);
        textBoxProvince.TabIndex = 11;
        // 
        // labelProvince
        // 
        labelProvince.AutoSize = true;
        labelProvince.Location = new Point(8, 212);
        labelProvince.Name = "labelProvince";
        labelProvince.Size = new Size(56, 15);
        labelProvince.TabIndex = 10;
        labelProvince.Text = "Province:";
        // 
        // textBoxCity
        // 
        textBoxCity.Location = new Point(111, 171);
        textBoxCity.Name = "textBoxCity";
        textBoxCity.Size = new Size(141, 23);
        textBoxCity.TabIndex = 9;
        // 
        // labelCity
        // 
        labelCity.AutoSize = true;
        labelCity.Location = new Point(8, 174);
        labelCity.Name = "labelCity";
        labelCity.Size = new Size(31, 15);
        labelCity.TabIndex = 8;
        labelCity.Text = "City:";
        // 
        // textBoxAddress2
        // 
        textBoxAddress2.Location = new Point(111, 133);
        textBoxAddress2.Name = "textBoxAddress2";
        textBoxAddress2.Size = new Size(301, 23);
        textBoxAddress2.TabIndex = 7;
        // 
        // labelAddress2
        // 
        labelAddress2.AutoSize = true;
        labelAddress2.Location = new Point(8, 136);
        labelAddress2.Name = "labelAddress2";
        labelAddress2.Size = new Size(61, 15);
        labelAddress2.TabIndex = 6;
        labelAddress2.Text = "Address 2:";
        // 
        // textBoxAddress1
        // 
        textBoxAddress1.Location = new Point(111, 95);
        textBoxAddress1.Name = "textBoxAddress1";
        textBoxAddress1.Size = new Size(301, 23);
        textBoxAddress1.TabIndex = 5;
        // 
        // labelAddress1
        // 
        labelAddress1.AutoSize = true;
        labelAddress1.Location = new Point(8, 98);
        labelAddress1.Name = "labelAddress1";
        labelAddress1.Size = new Size(61, 15);
        labelAddress1.TabIndex = 4;
        labelAddress1.Text = "Address 1:";
        // 
        // textBoxCompanyName
        // 
        textBoxCompanyName.Location = new Point(111, 57);
        textBoxCompanyName.Name = "textBoxCompanyName";
        textBoxCompanyName.Size = new Size(301, 23);
        textBoxCompanyName.TabIndex = 3;
        // 
        // labelCompanyName
        // 
        labelCompanyName.AutoSize = true;
        labelCompanyName.Location = new Point(8, 60);
        labelCompanyName.Name = "labelCompanyName";
        labelCompanyName.Size = new Size(97, 15);
        labelCompanyName.TabIndex = 2;
        labelCompanyName.Text = "Company Name:";
        // 
        // textBoxClientCode
        // 
        textBoxClientCode.Location = new Point(111, 19);
        textBoxClientCode.Name = "textBoxClientCode";
        textBoxClientCode.Size = new Size(141, 23);
        textBoxClientCode.TabIndex = 1;
        // 
        // labelClientCode
        // 
        labelClientCode.AutoSize = true;
        labelClientCode.Location = new Point(8, 22);
        labelClientCode.Name = "labelClientCode";
        labelClientCode.Size = new Size(72, 15);
        labelClientCode.TabIndex = 0;
        labelClientCode.Text = "Client Code:";
        // 
        // ClientEditDialog
        // 
        AcceptButton = buttonOk;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = buttonCancel;
        ClientSize = new Size(425, 538);
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
        Controls.Add(buttonOk);
        Controls.Add(buttonCancel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ClientEditDialog";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ClientEditDialog";
        Load += ClientEditDialog_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonCancel;
    private Button buttonOk;
    private RichTextBox richTextBoxNotes;
    private Label labelNotes;
    private CheckBox checkBoxCreditHold;
    private TextBox textBoxYtdSales;
    private Label labelYtdSales;
    private TextBox textBoxPostalCode;
    private Label labelPostalCode;
    private TextBox textBoxProvince;
    private Label labelProvince;
    private TextBox textBoxCity;
    private Label labelCity;
    private TextBox textBoxAddress2;
    private Label labelAddress2;
    private TextBox textBoxAddress1;
    private Label labelAddress1;
    private TextBox textBoxCompanyName;
    private Label labelCompanyName;
    private TextBox textBoxClientCode;
    private Label labelClientCode;
}