using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Inheritance
{
    public class Director : Manager
    {
        public decimal DirectorBonus { get => 10000; }

        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + DirectorBonus;
        }
    }
}
