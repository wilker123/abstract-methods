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

        public NaturalPerson(string name, double incomeAnual, double healthExpenditures)
            : base(name, incomeAnual)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            if (IncomeAnual < 20000.0)
            {
                return IncomeAnual * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return IncomeAnual * 0.25 - HealthExpenditures * 0.5;
            }
        }

    }
}
