using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Inheritance
{
    public class Worker : Employee
    {
        public int YearsOfExperience { get; set; }
        public decimal YearlyBonus { get => 1000; }


        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + (YearsOfExperience * YearlyBonus);
        }
    }
}
