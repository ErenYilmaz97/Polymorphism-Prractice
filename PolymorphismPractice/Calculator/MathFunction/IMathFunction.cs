using PolymorphismPractice.Calculator.Argument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Calculator.MathFunction
{
    public interface IMathFunction
    {
        public string GetName();
        public decimal Calculate(IArgument arg);
    }
}
