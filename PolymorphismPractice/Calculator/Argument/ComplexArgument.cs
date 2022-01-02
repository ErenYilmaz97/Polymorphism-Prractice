using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Calculator.Argument
{
    public class ComplexArgument : IArgument
    {
        //Farklı bir implementasyon uygulanabilir
        public int GetArgumentCount => throw new NotImplementedException();

        public decimal GetArgument(int argumentNumber)
        {
            throw new NotImplementedException();
        }
    }
}
