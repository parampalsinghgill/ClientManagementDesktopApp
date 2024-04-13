using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApp;
internal class ClientViewModel
{
    public ClientList Clients { get; private set; }


    public ClientViewModel()
    {
        Clients = ClientRepository.GetClients();
    }
}
