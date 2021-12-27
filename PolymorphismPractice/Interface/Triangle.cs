using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Interface
{
    public class Triangle : IShape
    {
        public decimal FirstEdge { get; set; }
        public decimal SecondEdge { get; set; }
        public decimal ThirdEdge { get; set; }


        public decimal CalculatePerimeter()
        {
            return FirstEdge + SecondEdge + ThirdEdge;
        }
    }
}
