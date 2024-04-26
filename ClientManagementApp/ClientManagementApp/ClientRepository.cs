using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApp;
internal class ClientRepository
{
    internal static ClientList GetClients()
    {
        ClientList clients = new ClientList();

        // SqlConnection
        using (SqliteConnection conn = new SqliteConnection(Config.connString))
        {
            String query = $"""
                           SELECT  ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes
                           FROM {Config.tableName}
                           """;
            
            using (SqliteCommand cmd = new SqliteCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                clients.Add(new Client
                                            {
                                                ClientCode = (string)reader["ClientCode"],
                                                CompanyName = (string)reader["CompanyName"],
                                                Address1 = (string)reader["Address1"],
                                                Address2 = reader["Address2"] as string,                    // could be null
                                                City = reader["City"] as string,                            // could be null
                                                Province = (String)reader["Province"],
                                                PostalCode = reader["PostalCode"] as string,                // could be null
                                                YtdSales = Convert.ToDecimal(reader["YTDSales"]),
                                                CreditHold = Convert.ToBoolean(reader["creditHold"]),
                                                Notes = reader["Notes"] as string                           // could be null
                                            });
                            }
                        }
                    } // exit reader
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("A SqlException occurred: " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An exception occurred: " + ex.Message);
                    throw;
                }
            } // close SqlCommand

        } // close SqlConnection


        return clients;
    }


    public static int AddClient(Client client)
    {
        string sqlQuery = $"""
                          INSERT INTO {Config.tableName}
                          (
                            ClientCode,
                            CompanyName,
                            Address1,
                            Address2,
                            City,
                            Province,
                            PostalCode,
                            YTDSales,
                            CreditHold,
                            Notes
                          )
                          VALUES
                          (
                            @clientCode,
                            @companyName,
                            @address1,
                            @address2,
                            @city,
                            @province,
                            @postalCode,
                            @ytdSales,
                            @creditHold,
                            @notes
                          )
                          """;

        return processQuery(sqlQuery, client);
    }


    public static int UpdateClient(Client client)
    {
        string sqlQuery = $"""
                          UPDATE {Config.tableName}
                          SET
                            CompanyName = @companyName,
                            Address1 = @address1,
                            Address2 = @address2,
                            City = @city,
                            Province = @province,
                            PostalCode = @postalCode,
                            YTDSales = @ytdSales,
                            CreditHold = @creditHold,
                            Notes = @notes
                          WHERE
                            ClientCode = @clientCode
                          """;

        return processQuery(sqlQuery, client);
    }

    private static int processQuery(String sqlQuery, Client client)
    {
        if (sqlQuery.Contains("INSERT") && !primaryKeyIsUnique(client))
        {
            throw new InvalidOperationException("Client Code is duplicate.");
        }
        else
        {
            using SqliteConnection conn = new SqliteConnection(Config.connString);
            using SqliteCommand cmd = new SqliteCommand(sqlQuery, conn);

            conn.Open();

            cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);
            cmd.Parameters.AddWithValue("@companyName", client.CompanyName);
            cmd.Parameters.AddWithValue("@address1", client.Address1);
            cmd.Parameters.AddWithValue("@address2", client.Address2);
            cmd.Parameters.AddWithValue("@city", client.City);
            cmd.Parameters.AddWithValue("@province", client.Province);
            cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
            cmd.Parameters.AddWithValue("@ytdSales", client.YtdSales);
            cmd.Parameters.AddWithValue("@creditHold", client.CreditHold);
            cmd.Parameters.AddWithValue("@notes", client.Notes);

            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected;
        }        
    }

    private static bool primaryKeyIsUnique(Client client)
    {
        string sqlQuery = $"""
                          SELECT COUNT(*) FROM {Config.tableName} 
                          WHERE ClientCode = @clientCode
                          """;

        using SqliteConnection conn = new SqliteConnection(Config.connString);
        using SqliteCommand cmd = new SqliteCommand(sqlQuery, conn);

        conn.Open();

        cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

        int count = Convert.ToInt32(cmd.ExecuteScalar());

        return count == 0;
    }

    public static int DeleteClient(Client client)
    {
        string sqlQuery = $"""
                          DELETE FROM {Config.tableName}
                          WHERE
                            ClientCode = @clientCode
                          """;

        using SqliteConnection conn = new SqliteConnection(Config.connString);
        using SqliteCommand cmd = new SqliteCommand(sqlQuery, conn);

        conn.Open();

        cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);
        
        int rowsAffected = cmd.ExecuteNonQuery();

        return rowsAffected;
    }
}
