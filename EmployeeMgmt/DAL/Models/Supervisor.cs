using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Supervisor : Employee
    {
        public decimal AnnualSalary { get; set; }
    }
}
