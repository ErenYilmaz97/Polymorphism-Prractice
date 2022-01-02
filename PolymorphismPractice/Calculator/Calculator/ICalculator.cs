using PolymorphismPractice.Calculator.Argument;
using PolymorphismPractice.Calculator.MathFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Calculator.Calculator
{
    public interface ICalculator
    {
        public void ListCalculatorFunctions();
        public void AddMathFunction(IMathFunction function);
        public decimal Calculate(string mathFunctionName, IArgument arg);

    }
}
