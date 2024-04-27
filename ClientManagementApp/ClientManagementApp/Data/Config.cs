using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApp.Data;
internal class Config
{
    private static readonly string databaseFileRelativePath = "../../../../Databases/Clients.db";
    private static readonly string folderPath = AppDomain.CurrentDomain.BaseDirectory;

    public static readonly string connString;

    public static readonly string tableName = "Clients";

    // Static constructor to initialize the const string field
    static Config()
    {
        connString = $"Data Source={Path.Combine(folderPath, databaseFileRelativePath)};";
    }

}
