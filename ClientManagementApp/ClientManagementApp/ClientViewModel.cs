using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApp;
internal class ClientViewModel : INotifyPropertyChanged
{
    public ClientList Clients { get; } // will be set from constructor
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

    internal void SetDisplayProduct(int index)
    {
        Client selectedClient = Clients[index];
        Client copyClient = new Client { 
                                    ClientCode = selectedClient.ClientCode, 
                                    CompanyName = selectedClient.CompanyName,
                                    Address1 = selectedClient.Address1,
                                    Address2 = selectedClient.Address2,
                                    City = selectedClient.City,
                                    Province = selectedClient.Province,
                                    PostalCode = selectedClient.PostalCode,
                                    YtdSales = selectedClient.YtdSales,
                                    CreditHold = selectedClient.CreditHold,
                                    Notes = selectedClient.Notes,
                                };

        DisplayClient = copyClient;
    }
}
