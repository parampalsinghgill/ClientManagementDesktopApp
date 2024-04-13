using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApp;
internal class ClientRepository
{
    internal static ClientList GetClients()
    {
        ClientList clients = new ClientList();

        String connString = """
                            Server=skeena.database.windows.net;
                            Initial Catalog=comp3602;
                            User ID=student;
                            Password=93ju5/trN5X;
                            Encrypt=True;
                            TrustServerCertificate=False;
                            Connection Timeout=30;
                            """;

        // SqlConnection
        using (SqlConnection conn = new SqlConnection(connString))
        {
            String tableName = "Client999999";
            String query = $"""
                           SELECT  ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes
                           FROM {tableName}
                           """;

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    String clientCode;  // not null
                    String companyName; // not null
                    String address1;    // not null
                    String address2;    // NULL
                    String city;        // NULL
                    String province;    // not null
                    String postalCode;  // NULL
                    decimal ytdSales;   // not null
                    bool creditHold;    // not null
                    String notes;       // NULL

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                clientCode = (String)reader["ClientCode"];
                                companyName = (String)reader["CompanyName"];
                                address1 = (String)reader["Address1"];

                                address2 = reader["Address2"] as String;
                                city = reader["City"] as String;

                                province = (String)reader["Province"];

                                postalCode = reader["PostalCode"] as String;

                                ytdSales = (decimal)reader["YTDSales"];
                                creditHold = (bool)reader["creditHold"];

                                notes = reader["Notes"] as String;

                                clients.Add(new Client
                                {
                                    ClientCode = clientCode,
                                    CompanyName = companyName,
                                    Address1 = address1,
                                    Address2 = address2,
                                    City = city,
                                    Province = province,
                                    PostalCode = postalCode,
                                    YtdSales = ytdSales,
                                    CreditHold = creditHold,
                                    Notes = notes
                                });
                            }
                        }
                    } // exit reader
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } // close SqlCommand

        } // close SqlConnection


        return clients;
    }
}
