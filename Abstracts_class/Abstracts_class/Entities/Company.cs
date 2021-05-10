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

        public override double TaxesPaid()
        {
            double tax = 0.0;
            if (NumberEmployees < 10)
            {
                tax = IncomeAnual * 0.16;
            }
            else
            {
                tax = IncomeAnual * 0.14;
            }
            return tax;
        }

    }
}
