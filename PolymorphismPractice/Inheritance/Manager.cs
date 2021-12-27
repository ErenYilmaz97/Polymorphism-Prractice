using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Inheritance
{
    public class Manager : Worker
    {
        public decimal ManagerBonus { get => 5000; }


        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + ManagerBonus;
        }
    }
}
