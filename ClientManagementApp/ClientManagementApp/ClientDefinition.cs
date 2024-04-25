using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApp;

// mapping of the Client table columns
internal class ClientDefinition
{
    public const int ClientCode = 0;
    public const int CompanyName = 1;
    public const int Address1 = 2;
    public const int Address2 = 3;
    public const int City = 4;
    public const int Province = 5;
    public const int PostalCode = 6;
    public const int YtdSales = 7;
    public const int CreditHold = 8;
    public const int Notes = 9;
}