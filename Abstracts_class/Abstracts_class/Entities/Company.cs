using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts_class.Entities
{
    class Company : TaxPayers
    {
        public int NumberEmployees { get; set; }

        public Company(int numberEmployees, string name, double incomeAnual)
            : base(name, incomeAnual)
        {
            NumberEmployees = numberEmployees;
        }
    }
}
