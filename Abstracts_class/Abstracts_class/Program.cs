using Abstracts_class.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts_class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayers> listTaxPayers = new List<TaxPayers>();

            Console.WriteLine(50000.00 * 0.25 - 2000 * 0.5);

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter payer #" + i + " data:");
                
                Console.Write("Individual or company (i/c)? ");
                char op = Char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double incomeAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listTaxPayers.Add(new NaturalPerson(name,incomeAnual, healthExpenditures));
                }
                else if (op == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    listTaxPayers.Add(new Company(numberEmployees, name, incomeAnual));
                }
                else
                {
                    Console.WriteLine("Opção inválida!!");
                }
            }
            Console.WriteLine("Taxes paid:");
            double totalTaxes = 0.0;
            foreach (TaxPayers tax in listTaxPayers)
            {
                totalTaxes += tax.TaxesPaid();
                Console.WriteLine(tax.Name + ": $" + tax.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();
            Console.WriteLine("Total taxes: $" + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
