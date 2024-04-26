using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApp;
public class Client
{
    public String ClientCode { get; set; }
    public String CompanyName { get; set; }
    public String Address1 { get; set; }
    public String Address2 { get; set; }
    public String City { get; set; }
    public String Province { get; set; }
    public String PostalCode { get; set; }
    public decimal YtdSales { get; set; }
    public bool CreditHold { get; set; }
    public String Notes { get; set; }
}
