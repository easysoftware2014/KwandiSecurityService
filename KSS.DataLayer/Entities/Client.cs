using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSS.DataLayer.Entities
{
    public class Client
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Contact Contact { get; set; }


    }
}
