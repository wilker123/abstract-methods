using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts_class.Entities
{
    class NaturalPerson : TaxPayers
    {
        public double HealthExpenditures { get; set; }

        public NaturalPerson(double healthExpenditures, string name, double incomeAnual)
            : base(name, incomeAnual)
        {
            HealthExpenditures = healthExpenditures;
        }
    }
}
