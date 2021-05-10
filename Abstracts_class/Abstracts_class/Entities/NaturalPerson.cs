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

        public override double TaxesPaid()
        {
            double tax = 0.0;
            if (IncomeAnual < 20000.00)
            {
                tax = (IncomeAnual * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                tax = (IncomeAnual * 0.25) - (HealthExpenditures * 0.5);
            }
            return tax;
        }

    }
}
