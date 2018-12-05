using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KSS.DataLayer.Entities;

namespace KSS.DataLayer
{
    public class KSSDBContext: DbContext
    {
        public KSSDBContext(): base("name=KwandiSecurityServices")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }  
    }
}
