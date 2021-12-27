using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Inheritance
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get => 4000; }


        //Çalışanın Maaşını Hesaplıyoruz
        public virtual decimal CalculateSalary()
        {
            return BaseSalary;
        }
    }
}
