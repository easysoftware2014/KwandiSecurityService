using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KSS.DataLayer.Entities;

namespace KSS.DataLayer.Repository
{
    public class ClientRepository
    {
        private readonly KSSDBContext _kssdbContext;

        public ClientRepository()
        {
            _kssdbContext = new KSSDBContext();
        }

        public List<Client> GetListOfClients()
        {
            return _kssdbContext.Clients.ToList();
        }
    }
}
