using PolymorphismPractice.Calculator.Argument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPractice.Calculator.MathFunction
{
    public class SumFunction : IMathFunction
    {
        //N adet parametre ile çalışabilir
        public decimal Calculate(IArgument arg)
        {
            decimal calculatedResult = 0;
            int argumentCount = arg.GetArgumentCount;

            for (int i = 0; i < argumentCount; i++)
            {
                calculatedResult += arg.GetArgument(i + 1);
            }

            return calculatedResult;
            
        }

        public string GetName() => nameof(SumFunction);
    }
}
