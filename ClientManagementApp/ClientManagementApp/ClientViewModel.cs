using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApp;
public class ClientViewModel : INotifyPropertyChanged
{
    public ClientList Clients { get; private set; } // will be set from constructor and refreshed with private method
    private Client displayClient;

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] String propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public ClientViewModel()
    {
        Clients = ClientRepository.GetClients();
        DisplayClient = new Client();                   // this has to be initialized with empty Client because the databinding gives error if DisplayClient gives null
    }

    public Client DisplayClient
    {
        get
        {
            return displayClient;
        }
        set
        {
            displayClient = value;
            OnPropertyChanged();
        }
    }

    public void syncViewModelWithDb()
    {
        this.Clients = ClientRepository.GetClients();
    }

    internal void SetDisplayProduct(Client client)
    {
        Client copyClient = new Client { 
                                    ClientCode = client.ClientCode, 
                                    CompanyName = client.CompanyName,
                                    Address1 = client.Address1,
                                    Address2 = client.Address2,
                                    City = client.City,
                                    Province = client.Province,
                                    PostalCode = client.PostalCode,
                                    YtdSales = client.YtdSales,
                                    CreditHold = client.CreditHold,
                                    Notes = client.Notes,
                                };

        DisplayClient = copyClient;
    }
}
