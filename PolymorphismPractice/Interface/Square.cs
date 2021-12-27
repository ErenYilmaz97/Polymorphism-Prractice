using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Interface
{
    public class Square : IShape
    {
        public decimal Edge { get; set; }


        public decimal CalculatePerimeter()
        {
            return 4 * Edge;
        }
    }
}
