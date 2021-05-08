using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts_class.Entities
{
    abstract class TaxPayers
    {
        public string Name { get; set; }
        public double IncomeAnual { get; set; }

        public TaxPayers(string name, double incomeAnual)
        {
            Name = name;
            IncomeAnual = incomeAnual;
        }

        public abstract double TaxesPaid();

    }
}
