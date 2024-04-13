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
        clientVM = new ClientViewModel();
        setBindings();
        setupDataGridView();
    }

    private void setBindings()
    {
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


        // add columns

        // column widths
        int clientCodeColumnWidth = 500;
        int companyNameColumnWidth = 200;
        int address1ColumnWidth = 120;
        int address2ColumnWidth = 100;
        int cityColumnWidth = 80;
        int provinceColumnWidth = 80;
        int postalCodeColumnWidth = 80;
        int ytdSalesColumnWidth = 80;
        int creditHoldColumnWidth = 100;
        int notesColumnWidth = 200;

        // column 1: clientCode
        DataGridViewTextBoxColumn clientCode = new DataGridViewTextBoxColumn();
        clientCode.Name = "clientCode";
        clientCode.DataPropertyName = "ClientCode";
        clientCode.HeaderText = "Client Code";
        clientCode.Width = clientCodeColumnWidth;
        clientCode.SortMode = DataGridViewColumnSortMode.NotSortable;
        //clientCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(clientCode);
        columnMinimumWidths.Add(clientCode.Name, clientCodeColumnWidth);

        // column 2: companyName
        DataGridViewTextBoxColumn companyName = new DataGridViewTextBoxColumn();
        companyName.Name = "companyName";
        companyName.DataPropertyName = "CompanyName";
        companyName.HeaderText = "Company Name";
        companyName.Width = companyNameColumnWidth;
        companyName.SortMode = DataGridViewColumnSortMode.NotSortable;
        // companyName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(companyName);

        // column 3: address1
        DataGridViewTextBoxColumn address1 = new DataGridViewTextBoxColumn();
        address1.Name = "address1";
        address1.DataPropertyName = "Address1";
        address1.HeaderText = "Address 1";
        address1.Width = address1ColumnWidth;
        address1.SortMode = DataGridViewColumnSortMode.NotSortable;
        //address1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(address1);

        // column 4: address2
        DataGridViewTextBoxColumn address2 = new DataGridViewTextBoxColumn();
        address2.Name = "address2";
        address2.DataPropertyName = "Address2";
        address2.HeaderText = "Address 2";
        address2.Width = address2ColumnWidth;
        address2.SortMode = DataGridViewColumnSortMode.NotSortable;
        //address2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(address2);

        // column 5: city
        DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn();
        city.Name = "city";
        city.DataPropertyName = "City";
        city.HeaderText = "City";
        city.Width = cityColumnWidth;
        city.SortMode = DataGridViewColumnSortMode.NotSortable;
        //city.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(city);

        // column 6: province
        DataGridViewTextBoxColumn province = new DataGridViewTextBoxColumn();
        province.Name = "city";
        province.DataPropertyName = "Province";
        province.HeaderText = "Province";
        province.Width = provinceColumnWidth;
        province.SortMode = DataGridViewColumnSortMode.NotSortable;
        //province.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(province);

        // column 7: postalCode
        DataGridViewTextBoxColumn postalCode = new DataGridViewTextBoxColumn();
        postalCode.Name = "postalCode";
        postalCode.DataPropertyName = "PostalCode";
        postalCode.HeaderText = "Postal Code";
        postalCode.Width = postalCodeColumnWidth;
        postalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
        //postalCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(postalCode);

        // column 8: ytdSales
        DataGridViewTextBoxColumn ytdSales = new DataGridViewTextBoxColumn();
        ytdSales.Name = "ytdSales";
        ytdSales.DataPropertyName = "YtdSales";
        ytdSales.HeaderText = "YTD Sales";
        ytdSales.Width = ytdSalesColumnWidth;
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
        creditHold.Width = creditHoldColumnWidth;
        creditHold.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        creditHold.SortMode = DataGridViewColumnSortMode.NotSortable;
        //creditHold.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        dataGridViewClients.Columns.Add(creditHold);

        // column 10: notes
        DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn();
        notes.Name = "notes";
        notes.DataPropertyName = "Notes";
        notes.HeaderText = "Notes";
        notes.Width = notesColumnWidth;
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
}
