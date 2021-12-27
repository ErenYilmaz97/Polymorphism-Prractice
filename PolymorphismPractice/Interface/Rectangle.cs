using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Interface
{
    public class Rectangle : IShape
    {
        public decimal LongEdge { get; set; }
        public decimal ShortEdge { get; set; }


        public decimal CalculatePerimeter()
        {
            return 2 * (LongEdge + ShortEdge);
        }
    }
}
