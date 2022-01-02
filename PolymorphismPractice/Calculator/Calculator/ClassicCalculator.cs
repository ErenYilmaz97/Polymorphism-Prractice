using PolymorphismPractice.Calculator.Argument;
using PolymorphismPractice.Calculator.MathFunction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Calculator.Calculator
{
    public class ClassicCalculator : ICalculator
    {
        private List<IMathFunction> Functions { get; }

        public ClassicCalculator() => this.Functions = new List<IMathFunction>();

        

        public decimal Calculate(string mathFunctionName, IArgument arg)
        {
            IMathFunction function = this.Functions.First(x => x.GetName() == mathFunctionName);
            return function.Calculate(arg);
        }


        public void AddMathFunction(IMathFunction function)
        {
            var mathFunction = this.Functions.FirstOrDefault(x => x.GetName() == function.GetName());

            if(mathFunction == null)
            {
                Functions.Add(function);
            }
        }

        public void ListCalculatorFunctions()
        {
            this.Functions.ForEach(function =>
            {
                Console.WriteLine(function.GetName());
            });
        }
    }
}
