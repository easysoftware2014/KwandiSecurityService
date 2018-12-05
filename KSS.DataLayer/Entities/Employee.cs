using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSS.DataLayer.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public long UserId { get; set; }

        public List<Qualification> Qualifications { get; set; }

    }
}
