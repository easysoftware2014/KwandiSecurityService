using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace KSS.DataLayer.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; } 
        public string ContactNumber { get; set; } 
        public string Line1 { get; set; } 
        public string Line2 { get; set; } 
        public string Line3 { get; set; } 
        public string PostalCode { get; set; }
        public string City { get; set; }
        public UserStatus UserStatus { get; set; }  
        public int IdNumber { get; set; }  


    }
}
