using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagementApp;
public partial class ClientEditDialog : Form
{
    public ClientViewModel ClientVM { get; private set; }
    public bool IsEditMode { get; set; }

    public ClientEditDialog(ClientViewModel ClientVM)
    {
        this.ClientVM = ClientVM;
        InitializeComponent();
    }

    private void ClientEditDialog_Load(object sender, EventArgs e)
    {
        if (this.IsEditMode)
        {
            this.Text = "Editing Existing Client";
        }
        else
        {
            this.Text = "Adding New Client";
        }

        setBindings();
    }

    private void setBindings()
    {
        textBoxClientCode.DataBindings.Add("Text", ClientVM, "DisplayClient.ClientCode");
        textBoxCompanyName.DataBindings.Add("Text", ClientVM, "DisplayClient.CompanyName");
        textBoxAddress1.DataBindings.Add("Text", ClientVM, "DisplayClient.Address1");
        textBoxAddress2.DataBindings.Add("Text", ClientVM, "DisplayClient.Address2");
        textBoxCity.DataBindings.Add("Text", ClientVM, "DisplayClient.City");
        textBoxProvince.DataBindings.Add("Text", ClientVM, "DisplayClient.Province");
        textBoxPostalCode.DataBindings.Add("Text", ClientVM, "DisplayClient.PostalCode");
        textBoxYtdSales.DataBindings.Add("Text", ClientVM, "DisplayClient.YtdSales");
        checkBoxCreditHold.DataBindings.Add("Checked", ClientVM, "DisplayClient.CreditHold");
        richTextBoxNotes.DataBindings.Add("Text", ClientVM, "DisplayClient.Notes");
    }

    private void buttonOk_Click(object sender, EventArgs e)
    {
        // insert new record if not edit mode
        //
        // and updte the record if it was edit mode

        int rowsAffected;
        String action = "";
        Client client = ClientVM.DisplayClient;

        try
        {
            if (this.IsEditMode)
            {
                rowsAffected = ClientRepository.UpdateClient(client);
                action = "editing";
            }
            else
            {
                rowsAffected = ClientRepository.AddClient(client);
                action = "adding new";
            }

            if (rowsAffected == 0)
            {
                throw new Exception($"No rows affected while {action} Client in the database.");
            }

            // make the DialofResultOk here when we do we did what was nedded successfully
            this.DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            if (ex is SqlException || ex is InvalidOperationException)
            {
                MessageBox.Show(ex.Message,
                            "Data Access Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(ex.Message,
                            "Processing Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }

            textBoxClientCode.Focus();
            textBoxClientCode.SelectAll();
        }
    }
}
