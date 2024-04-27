using ClientManagementApp.Common;
using ClientManagementApp.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace ClientManagementApp;

public partial class MainForm : Form
{
    private ClientViewModel clientVM;
    Dictionary<String, int> columnMinimumWidths = new Dictionary<String, int>();

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        try
        {
            clientVM = new ClientViewModel();
            setBindings();
            setupDataGridView();
        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message,
                            "Database Connection error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message,
                            "Processing Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }

    private void setBindings()
    {
        // data grid view
        dataGridViewClients.AutoGenerateColumns = false;
        dataGridViewClients.DataSource = clientVM.Clients;
    }

    private void setupDataGridView()
    {
        // configure for readonly 
        dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewClients.MultiSelect = false;
        dataGridViewClients.AllowUserToAddRows = false;
        dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
        dataGridViewClients.AllowUserToOrderColumns = false;
        dataGridViewClients.AllowUserToResizeColumns = true;
        dataGridViewClients.AllowUserToResizeRows = false;
        dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
        dataGridViewClients.RowHeadersVisible = false;
        // Set the Anchor property to make DataGridView resize with the form
        dataGridViewClients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        // dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        // set default font size
        dataGridViewClients.DefaultCellStyle.Font = new Font(dataGridViewClients.DefaultCellStyle.Font.FontFamily, 11);

        // add columns

        // column widths
        int clientCodeColumnWidth = 80;
        int companyNameColumnWidth = 150;
        int address1ColumnWidth = 120;
        int address2ColumnWidth = 80;
        int cityColumnWidth = 80;
        int provinceColumnWidth = 70;
        int postalCodeColumnWidth = 80;
        int ytdSalesColumnWidth = 80;
        int creditHoldColumnWidth = 80;
        // int notesColumnWidth = 150;

        double defaultWidthIncreaseFactor = 1.5;

        // column 1: clientCode
        DataGridViewTextBoxColumn clientCode = new DataGridViewTextBoxColumn();
        clientCode.Name = "clientCode";
        clientCode.DataPropertyName = "ClientCode";
        clientCode.HeaderText = "Client Code";
        clientCode.Width = clientCodeColumnWidth;
        clientCode.SortMode = DataGridViewColumnSortMode.NotSortable;
        //clientCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(clientCode);
        columnMinimumWidths.Add(clientCode.Name, clientCodeColumnWidth);        // if AutoSizeColumnMode.Fill is set on columns we cannot set minimum width

        // column 2: companyName
        DataGridViewTextBoxColumn companyName = new DataGridViewTextBoxColumn();
        companyName.Name = "companyName";
        companyName.DataPropertyName = "CompanyName";
        companyName.HeaderText = "Company Name";
        companyName.Width = (int)(companyNameColumnWidth * defaultWidthIncreaseFactor);
        companyName.SortMode = DataGridViewColumnSortMode.NotSortable;
        //companyName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;         // can only set minimum width or AutoSizeColumnMode.Fill
        dataGridViewClients.Columns.Add(companyName);

        // column 3: address1
        DataGridViewTextBoxColumn address1 = new DataGridViewTextBoxColumn();
        address1.Name = "address1";
        address1.DataPropertyName = "Address1";
        address1.HeaderText = "Address 1";
        address1.Width = (int)(address1ColumnWidth * defaultWidthIncreaseFactor);
        address1.SortMode = DataGridViewColumnSortMode.NotSortable;
        //address1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(address1);

        // column 4: address2
        DataGridViewTextBoxColumn address2 = new DataGridViewTextBoxColumn();
        address2.Name = "address2";
        address2.DataPropertyName = "Address2";
        address2.HeaderText = "Address 2";
        address2.Width = (int)(address2ColumnWidth * defaultWidthIncreaseFactor);
        address2.SortMode = DataGridViewColumnSortMode.NotSortable;
        //address2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(address2);

        // column 5: city
        DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn();
        city.Name = "city";
        city.DataPropertyName = "City";
        city.HeaderText = "City";
        city.Width = (int)(cityColumnWidth * defaultWidthIncreaseFactor);
        city.SortMode = DataGridViewColumnSortMode.NotSortable;
        //city.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(city);

        // column 6: province
        DataGridViewTextBoxColumn province = new DataGridViewTextBoxColumn();
        province.Name = "city";
        province.DataPropertyName = "Province";
        province.HeaderText = "Province";
        province.Width = (int)(provinceColumnWidth * defaultWidthIncreaseFactor);
        province.SortMode = DataGridViewColumnSortMode.NotSortable;
        //province.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(province);

        // column 7: postalCode
        DataGridViewTextBoxColumn postalCode = new DataGridViewTextBoxColumn();
        postalCode.Name = "postalCode";
        postalCode.DataPropertyName = "PostalCode";
        postalCode.HeaderText = "Postal Code";
        postalCode.Width = (int)(postalCodeColumnWidth * defaultWidthIncreaseFactor);
        postalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
        //postalCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(postalCode);

        // column 8: ytdSales
        DataGridViewTextBoxColumn ytdSales = new DataGridViewTextBoxColumn();
        ytdSales.Name = "ytdSales";
        ytdSales.DataPropertyName = "YtdSales";
        ytdSales.HeaderText = "YTD Sales";
        ytdSales.Width = (int)(ytdSalesColumnWidth * defaultWidthIncreaseFactor);
        // special formatting for decimal or float data
        ytdSales.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        ytdSales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        ytdSales.DefaultCellStyle.Format = "N2";

        ytdSales.SortMode = DataGridViewColumnSortMode.NotSortable;
        //ytdSales.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(ytdSales);

        // column 9: creditHold
        DataGridViewCheckBoxColumn creditHold = new DataGridViewCheckBoxColumn();
        creditHold.Name = "creditHold";
        creditHold.DataPropertyName = "CreditHold";
        creditHold.HeaderText = "Credit Hold";
        creditHold.Width = (int)(creditHoldColumnWidth * defaultWidthIncreaseFactor);
        creditHold.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        creditHold.SortMode = DataGridViewColumnSortMode.NotSortable;
        //creditHold.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(creditHold);

        // column 10: notes
        DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn();
        notes.Name = "notes";
        notes.DataPropertyName = "Notes";
        notes.HeaderText = "Notes";
        // notes.Width = notesColumnWidth;
        notes.SortMode = DataGridViewColumnSortMode.NotSortable;
        notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(notes);
    }

    private void dataGridViewClients_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
    {
        if (columnMinimumWidths.ContainsKey(e.Column.Name))
        {
            int minWidth = columnMinimumWidths[e.Column.Name];
            // Set the column width to the minimum width if it's less than the minimum
            if (e.Column.Width < minWidth)
            {
                e.Column.Width = minWidth;
            }
        }
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
        openClientEditDialog(true);
    }

    private void buttonNew_Click(object sender, EventArgs e)
    {
        openClientEditDialog(false);
    }

    private void openClientEditDialog(bool isEditMode)
    {
        // if edit mode, set the display product in edit form otherwise set it as empty
        if (isEditMode)
        {
            clientVM.SetDisplayProduct(clientVM.Clients[dataGridViewClients.CurrentRow.Index]);
        }
        else
        {
            clientVM.SetDisplayProduct(new Client());
        }

        ClientEditDialog dlg = new ClientEditDialog(clientVM);
        dlg.IsEditMode = isEditMode;

        dlg.ShowDialog();

        // refresh Grid is a way the same row is still selected
        if (dlg.DialogResult == DialogResult.OK)
        {
            refreshGrid();
        }

        dlg.Dispose();
    }

    private void refreshGrid()
    {
        clientVM.syncViewModelWithDb();

        int selectedIndex = dataGridViewClients.CurrentRow.Index;
        dataGridViewClients.DataSource = clientVM.Clients;

        if (selectedIndex >= 0 && selectedIndex < dataGridViewClients.Rows.Count)
        {
            dataGridViewClients.Rows[selectedIndex].Selected = true;
        }
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        // Confirm that the user wants to delete the record permanently. then delete
        try
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the record permanently?",
                                                  "Delete Permanently?",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Client client = clientVM.Clients[dataGridViewClients.CurrentRow.Index];

                int rowsAffected = ClientRepository.DeleteClient(client);
                refreshGrid();

                if (rowsAffected != 1)
                {
                    throw new Exception("More than 1 record was affected with deletion.");
                }
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message,
                            "Database Connection error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message,
                            "Processing Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }

    private void MainForm_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (dataGridViewClients.Focused)
            {
                // Prevent further processing of Enter Key
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Call the event handler of the Edit button
                buttonEdit_Click(sender, e);
            }
        }
    }
}
